import requests

response = requests.get('https://public-api.tracker.gg/v2/apex/standard/profile/psn/Daltoosh' + '?TRN-Api-Key=xxxx')
print(response.status_code)    # HTTPのステータスコード取得
print(response.text) 