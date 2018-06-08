const express = require('express');
const addressController = express.Router();

addressController.get("/:address/balance", (req,res) => {

    const response = require('../mocks/address-balance');

    res.json(response);
    res.end();
      

});

addressController.get("/:address/transactions", (req,res) => {

    const response = require('../mocks/address-transactions');

    res.json(response);
    res.end();

});

module.exports = addressController;