package org.softuni.web;

import org.softuni.utils.ResponseEntityBuilder;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

import javax.servlet.http.HttpServletResponse;

@Controller
@RequestMapping("/transactions")
public class TransactionController {

    @RequestMapping("/pending")
    public ResponseEntity<String> getPending(){
        return ResponseEntityBuilder.buildJsonResponseEntity("pending-transactions.json");
    }

    @RequestMapping("/confirmed")
    public ResponseEntity<String> getConfirmed(){
        return ResponseEntityBuilder.buildJsonResponseEntity("confirmed-transactions.json");
    }

    @RequestMapping("/{id}")
    public ResponseEntity<String> getById(@PathVariable("id")String id){
        return ResponseEntityBuilder.buildJsonResponseEntity("transaction.json");
    }

    @RequestMapping(value = "/send", method = RequestMethod.POST)
    public ResponseEntity<String> send(HttpServletResponse response){
        return ResponseEntityBuilder.buildJsonResponseEntity("transaction-send.json");
    }

}
