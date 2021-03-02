package queen.talls.raul.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;
import queen.talls.raul.model.Universe;
import queen.talls.raul.service.UniverseService;

@RestController
@RequestMapping("api/universe")
public class UniverseController {

    @Autowired
    private UniverseService universeService;

    @RequestMapping(method = RequestMethod.GET, path = "/addUniverse")
    public ResponseEntity<String> addUniverse(){

        String test = "test";

        Universe universe = new Universe();
        universe.setHistory("test");
        universe.setName("teeest");
        universeService.addUniverse();

        return new ResponseEntity<String>(test, HttpStatus.OK);
    }
}
