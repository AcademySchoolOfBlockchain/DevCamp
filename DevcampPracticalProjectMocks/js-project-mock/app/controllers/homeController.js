const express = require('express');
const homeController = express.Router();

// The mock info you will send if not "implemented"
const infoMock = require('../mocks/info');
const debugMock = require('../mocks/debug');
const chainMock = require('../mocks/chain');

homeController.get("/info", (req, res) => {

    res.json(infoMock);
    res.end();

});

homeController.get('/debug', (req, res) => {

    res.json(debugMock);
    res.end();

});

homeController.get('/debug/reset-chain', (req, res) => {

    const message = JSON.stringify({
        "message": "The chain was reset to its genesis block"
    });

    res.json(message);
    res.end();

});

homeController.get('/blocks', (req, res) => {

    const response = require('../mocks/chain');

    res.json(response);
    res.end();

});

homeController.get("/blocks/:id", (req, res) => {

    let id = req.params.id;

    let json = require('../mocks/block');
    json.id = id;

    let response = JSON.stringify(json);

    res.json(response);

    res.end();

});

homeController.get('/balances', (req, res) => {

    let response = require('../mocks/balances');

    res.json(response);
    res.end();

});

homeController.get('/debug/mine/:minerAddress/:difficulty', (req, res) => {

    const response = require('../mocks/miner-difficulty');

    res.json(response);
    res.end();

});



module.exports = homeController;