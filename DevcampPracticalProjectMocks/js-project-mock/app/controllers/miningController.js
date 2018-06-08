const express = require('express');
const miningController = express.Router();

miningController.get("/get-mining-job/:address", (req, res) => {

    const response = require('../mocks/mining-job');

    res.json(response);
    res.end();

});

miningController.post("/submit-mined-block", (req, res) => {

    const response = {
        "message": "Block accepted, reward paid: 5000350 microcoins"
    };

    res.json(response);
    res.end();

});

module.exports = miningController;