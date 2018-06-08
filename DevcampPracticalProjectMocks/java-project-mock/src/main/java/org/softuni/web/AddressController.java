package org.softuni.web;

import org.softuni.utils.ResponseEntityBuilder;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
@RequestMapping("/address")
public class AddressController {

    @RequestMapping("/{id}/balance")
    public ResponseEntity<String> balance(@PathVariable("id")String id){
        return ResponseEntityBuilder.buildJsonResponseEntity("address-balance.json");
    }

    @RequestMapping("/{id}/transactions")
    public ResponseEntity<String> transactions(@PathVariable("id")String id){
        return ResponseEntityBuilder.buildJsonResponseEntity("address-transactions.json");
    }

}
