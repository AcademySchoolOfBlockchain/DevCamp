from flask import Blueprint, Flask, json

peers = Blueprint('peers', __name__)
app = Flask(__name__)


@peers.route('/peers', methods=['GET'])
def get_peers():
    response = load_json('peers.json')
    return json.jsonify(response)


@peers.route('/peers/connect', methods=['POST'])
def peers_connect():
    response = load_json('peer-connected.json')
    return json.jsonify(response)


@peers.route('/peers/notify-new-block', methods=['POST'])
def notify_new_block():
    response = load_json('notify-new-block.json')
    return json.jsonify(response)


def load_json(filename):
    with app.open_resource('../mocks/' + filename) as f:
        data = json.load(f)

    return data
