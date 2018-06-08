from flask import Blueprint, Flask, json

transactions = Blueprint('transactions', __name__)
app = Flask(__name__)


@transactions.route('/transactions/send', methods=['POST'])
def post_transaction():
    response = load_json('transaction-send.json')
    return json.jsonify(response)


@transactions.route('/transactions/pending', methods=['GET'])
def get_pending_transactions():
    response = load_json('pending-transactions.json')
    return json.jsonify(response)


@transactions.route('/transactions/confirmed', methods=['GET'])
def get_confirmed_transactions():
    response = load_json('confirmed-transactions.json')
    return json.jsonify(response)


@transactions.route('/transactions/<string:transaction_id>', methods=['GET'])
def get_transaction_by_id(transaction_id):
    response = load_json('transaction.json')
    return json.jsonify(response)


def load_json(filename):
    with app.open_resource('../mocks/' + filename) as f:
        data = json.load(f)

    return data
