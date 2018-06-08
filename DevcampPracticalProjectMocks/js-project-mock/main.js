// Core
const express = require('express');
const app = express();

// Middlewares
const bodyParser = require('body-parser');
const cookieParser = require('cookie-parser');
const morgan = require('morgan');

// Environment
const HTTP_PORT = process.env.HTTP_PORT || 5555;
const PEER_PORT = process.env.PEER_PORT || 3333;

// Log incoming requests
app.use(morgan('dev'));
// parse cookies
app.use(cookieParser());
// parse application/x-www-form-urlencoded
app.use(bodyParser.urlencoded({ extended: false }))
// parse application/json
app.use(bodyParser.json())

const HomeController = require('./app/controllers/homeController');
const TransactionController = require('./app/controllers/transactionController');
const MiningController = require('./app/controllers/miningController');
const PeerController = require('./app/controllers/peerController');
const AddressController = require('./app/controllers/addressController');

app.use('/', HomeController);
app.use('/transactions', TransactionController);
app.use('/mining', MiningController);
app.use('/peers', PeerController);
app.use('/address', AddressController);

app.listen(HTTP_PORT, () => {

    console.log("Deployment was successfull!");
    console.log(`Listening on port ${HTTP_PORT}`);

});
