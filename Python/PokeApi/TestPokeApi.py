import requests

POKE_API_URL = 'https://pokeapi.co/api/v2/pokemon/'  # APIのURL

def main(id):
    r = requests.get(POKE_API_URL + id, timeout=5)  # 5秒以上応答がない場合はエラー
    if not check_stats(r):
        return

    data = r.json()
    name = data['name']
    image_url = data['sprites']['front_default']  # 画像のurl
    file_path = './' + name + '.jpg'  # 格納するファイルパス

    download_image(image_url, file_path)

def check_stats(req):
    if req.status_code != 200:
        print('ポケモンを逃した')  # アクセスエラー
        return False
    return True

def download_image(url, fpath):
    r = requests.get(url, stream=True)
    if not check_stats(r):
        return

    with open(fpath, "wb") as f:
        f.write(r.content)
        print('ポケモンゲットだぜ！')  # 画像の取得成功

if __name__ == '__main__':
    main('pikachu')