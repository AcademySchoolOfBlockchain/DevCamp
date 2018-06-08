from flask import Blueprint, Flask, json

mining = Blueprint('mining', __name__)
app = Flask(__name__)

@mining.route('/mining/get-mining-job/<string:address>', methods=['GET'])
def get_mining_job(address):
    response = load_json('mining-job.json')
    return json.jsonify(response)


@mining.route('/mining/submit-mined-block', methods=['POST'])
def submit_mined_block():
    response = load_json('submit-new-block.json')
    return json.jsonify(response)


def load_json(filename):
    with app.open_resource('../mocks/' + filename) as f:
        data = json.load(f)

    return data
