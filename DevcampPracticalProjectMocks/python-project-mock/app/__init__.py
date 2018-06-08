from flask import Flask

from .views.home import home
from .views.transactions import transactions
from .views.address import address
from .views.mining import mining
from .views.peers import peers

app = Flask(__name__)
# Load the public configuration
app.config.from_object('config')

app.register_blueprint(home)
app.register_blueprint(transactions)
app.register_blueprint(address)
app.register_blueprint(mining)
app.register_blueprint(peers)
