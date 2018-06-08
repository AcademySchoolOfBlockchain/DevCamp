package org.softuni.web;

import org.softuni.utils.ResponseEntityBuilder;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

@Controller
@RequestMapping("/peers")
public class PeersController {

    public PeersController(){}

    @RequestMapping
    public ResponseEntity<String> peers(){
        return ResponseEntityBuilder.buildJsonResponseEntity("peers.json");
    }

    @RequestMapping(value = "/connect", method = RequestMethod.POST)
    public ResponseEntity<String> connect(){
        return ResponseEntityBuilder.buildJsonResponseEntity("peer-connected.json");
    }

    @RequestMapping(value = "/notify-new-block", method = RequestMethod.POST)
    public ResponseEntity<String> notifyNewBlock(){
        return  ResponseEntityBuilder.buildJsonResponseEntity("notify-new-block.json");
    }

}
