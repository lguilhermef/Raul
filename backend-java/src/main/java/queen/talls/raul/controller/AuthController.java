package queen.talls.raul.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;
import queen.talls.raul.model.dto.RaulUserLoginDto;
import queen.talls.raul.model.dto.RaulUserRegisterDto;
import queen.talls.raul.model.RaulUser;
import queen.talls.raul.service.AuthService;

@RestController
@RequestMapping("api/auth")
public class AuthController {

    @Autowired
    private AuthService authService;


    @RequestMapping(method = RequestMethod.POST, path = "/login")
    public ResponseEntity<RaulUser> login (@RequestBody RaulUserLoginDto raulUserLoginData) {

        RaulUser raulUser = authService.loginUser(raulUserLoginData);

        if (raulUser == null) {
           return new ResponseEntity<RaulUser>(raulUser, HttpStatus.BAD_REQUEST);
        }

        return new ResponseEntity<RaulUser>(raulUser , HttpStatus.OK);
    }

    @RequestMapping(method = RequestMethod.POST, path = "/register")
    public ResponseEntity<RaulUser> register (@RequestBody RaulUserRegisterDto raulUserRegisterDto) {

        RaulUser raulUser = authService.registerUser(raulUserRegisterDto);
        //TODO: This must return a DTO and not the actual RaulUser instance
        if (raulUser == null) {
            return new ResponseEntity<RaulUser>(raulUser, HttpStatus.BAD_REQUEST);
        }

        return new ResponseEntity<RaulUser>(raulUser, HttpStatus.OK);
    }
}