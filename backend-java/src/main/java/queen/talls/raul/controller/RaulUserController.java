package queen.talls.raul.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;
import queen.talls.raul.model.RaulUser;
import queen.talls.raul.service.RaulUserService;

@RestController
@RequestMapping("api/raulUser")
public class RaulUserController {

    @Autowired
    private RaulUserService raulUserService;

    @RequestMapping(method = RequestMethod.POST, path = "/addUser")
    public ResponseEntity<RaulUser> addUser(@RequestBody String username, @RequestBody String password){

        RaulUser raulUser = raulUserService.addRaulUser(username, password);
        return new ResponseEntity<RaulUser>(raulUser, HttpStatus.OK);
    }
}
