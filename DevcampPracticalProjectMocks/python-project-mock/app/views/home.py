from flask import Blueprint, Flask, json

import os

"""
    This is just a mock-up of a real application.
    You can use render_template to render templates from the /templates project directory instead of
    reading .json from mock files.
    
    In case you want to modularize the application even more 
    you can check this http://exploreflask.com/en/latest/blueprints.html and restructure by letting different parts
    of the application have their own static/template folders. 
   
    It is all up to you ^^
"""

home = Blueprint('home', __name__)
app = Flask(__name__)


@home.route('/info', methods=['GET'])
def get_info():
    response = load_json('info.json')
    return json.jsonify(response)


@home.route('/debug', methods=['GET'])
def get_debug():
    response = load_json('debug.json')
    return json.jsonify(response)


@home.route('/debug/reset-chain', methods=['GET'])
def reset_chain():
    response = load_json('reset-chain.json')
    return json.jsonify(response)


@home.route('/debug/mine/<string:miner_address>/<int:difficulty>', methods=['GET'])
def get_mining_job_by_address_and_difficulty(miner_address, difficulty):
    response = load_json('miner-difficulty.json')
    return json.jsonify(response)


@home.route('/blocks', methods=['GET'])
def get_blocks():
    response = load_json('chain.json')
    return json.jsonify(response)


@home.route('/blocks/<int:block_id>', methods=['GET'])
def get_block_by_id(block_id):
    response = load_json('block.json')
    return json.jsonify(response)


@home.route('/balances', methods=['GET'])
def get_balances():
    response = load_json('balances.json')
    return json.jsonify(response)


def load_json(filename):
    with app.open_resource('../mocks/' + filename) as f:
        data = json.load(f)

    return data
