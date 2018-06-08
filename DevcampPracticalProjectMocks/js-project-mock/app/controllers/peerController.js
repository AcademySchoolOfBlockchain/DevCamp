const express = require('express');
const peerController = express.Router();


peerController.get('/', (req, res) => {

    const response = require('../mocks/peers');

    res.json(response);
    res.end();

});

peerController.post('/connect', (req, res) => {

    let url = req.body.peerUrl;

    const response = {
        message: `Connected to peer ${url}`
    };

    res.json(response);
    res.end();

});


peerController.post('/notify-new-block', (req, res) => {

    const response = {
        message: "Thank you for the notification."
    };

    res.json(response);
    res.end();

});


module.exports = peerController;