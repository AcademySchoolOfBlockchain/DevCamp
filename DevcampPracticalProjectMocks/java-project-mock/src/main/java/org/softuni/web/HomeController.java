package org.softuni.web;

import org.softuni.utils.ResponseEntityBuilder;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;


@Controller
@RequestMapping("/")
public class HomeController {

    public HomeController(){}

    @RequestMapping("/info")
    public ResponseEntity<String> info(){
        return ResponseEntityBuilder.buildJsonResponseEntity("info.json");
    }

    @RequestMapping("/debug")
    public ResponseEntity<String> debug(){
        return ResponseEntityBuilder.buildJsonResponseEntity("debug.json");
    }

    @RequestMapping("/debug/reset-chain")
    public ResponseEntity<String> resetChain(){
        return ResponseEntityBuilder.buildJsonResponseEntity("reset-chain.json");
    }

    @RequestMapping("/debug/mine/{minerId}/{difficulty}")
    public ResponseEntity<String> transactionsByMinerIdAndDifficulty(
                                                     @PathVariable("minerId")String minerId,
                                                     @PathVariable("difficulty")Integer difficulty){
        return ResponseEntityBuilder.buildJsonResponseEntity("miner-difficulty.json");
    }

    @RequestMapping("/blocks")
    public ResponseEntity<String> blocks(){
        return ResponseEntityBuilder.buildJsonResponseEntity("chain.json");
    }

    @RequestMapping("/blocks/{index}")
    public ResponseEntity<String> block(@PathVariable("index")Integer index){
        return ResponseEntityBuilder.buildJsonResponseEntity("block.json");
    }

    @RequestMapping("/balances")
    public ResponseEntity<String> balances(){
        return ResponseEntityBuilder.buildJsonResponseEntity("balances.json");
    }

}
