package org.softuni.web;


import org.softuni.utils.ResponseEntityBuilder;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;


@Controller
@RequestMapping("/mining")
public class MiningController {

    public MiningController(){}

    @RequestMapping("/get-mining-job/{id}")
    public ResponseEntity<String> getMiningJob(@PathVariable("id")String id){
        return ResponseEntityBuilder.buildJsonResponseEntity("mining-job.json");
    }

    @RequestMapping(value = "/submit-mined-block", method = RequestMethod.POST)
    public ResponseEntity<String> submitMinedBlock(){
        return ResponseEntityBuilder.buildJsonResponseEntity("submit-new-block.json");
    }

}
