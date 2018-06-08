const express = require('express');
const transactionController = express.Router();

transactionController.get('/pending', (req, res) => {

    const response = require('../mocks/pending-transactions');

    res.json(response);
    res.end();


});

transactionController.get("/confirmed", (req, res) => {

    const response = require('../mocks/confirmed-transactions');

    res.json(response);
    res.end();

});

transactionController.get('/:txHash', (req, res) => {

    const response = require('../mocks/transaction');

    res.json(response);
    res.end();

});

transactionController.post('/send', (req, res) => {

    const response = JSON.stringify({
        "transactionDataHash": "cd8d9a345bb208c6f9b8acd6b8eefefab20c8a"
    });

    res.json(response);
    res.end();

});

module.exports = transactionController;