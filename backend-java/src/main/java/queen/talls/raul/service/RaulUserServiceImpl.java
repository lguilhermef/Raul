package queen.talls.raul.service;

import org.springframework.stereotype.Service;
import queen.talls.raul.model.RaulUser;

@Service
public class RaulUserServiceImpl implements RaulUserService {

    @Override
    public RaulUser addRaulUser(String username, String password) {


        return new RaulUser("Zé", password, "l");
    }
}
