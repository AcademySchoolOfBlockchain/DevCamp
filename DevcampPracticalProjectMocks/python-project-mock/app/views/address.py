from flask import Blueprint, Flask, json

address = Blueprint('address', __name__)
app = Flask(__name__)

@address.route('/address/<string:address>/transactions')
def get_transactions_by_address(address):
    response = load_json('address-transactions.json')
    return json.jsonify(response)


@address.route('/address/<string:address>/balance')
def get_balance_by_address(address):
    response = load_json('address-balance.json')
    return json.jsonify(response)


def load_json(filename):
    with app.open_resource('../mocks/' + filename) as f:
        data = json.load(f)
    return data
