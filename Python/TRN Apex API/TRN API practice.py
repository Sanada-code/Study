from pprint import pprint
import requests
import json
import  sys

TRN_URL = 'https://public-api.tracker.gg/v2/apex/standard'
API_KEY = 'xxxxx'
    
def GetProfile(platform, playerId):
    sendUrl  = TRN_URL + '/profile'
    sendUrl += '/' + platform
    sendUrl += '/' + playerId 
    sendUrl += '?TRN-Api-Key=' + API_KEY
    print('sendUrl :', sendUrl)
    
    # http getリクエスト送信
    response = requests.get(sendUrl)
    
    return response

def CheckResponseStats(response):
    print("Response status code:", response.status_code)    # HTTPのステータスコード取得
    
    #200以外の場合は失敗
    if response.status_code != 200:
        print(response.status_code, 'error')
        sys.exit()
        
def DispStats(json):
    # statsに主な戦績データが入ってるぽい
    stats = json['data']['segments'][0]['stats']
    #pprint(stats)

    for key, value in stats.items():
        print(key, value['displayValue'])
        
if __name__ == '__main__':
    response = GetProfile('origin', 'CR_Ras_LOG')
    CheckResponseStats(response)
    
    # そのままだと見にくいのでjsonを整形
    json = json.loads(response.text)
    #pprint(json)
    
    DispStats(json)