package queen.talls.raul.service;

import queen.talls.raul.model.dto.RaulUserLoginDto;
import queen.talls.raul.model.dto.RaulUserRegisterDto;
import queen.talls.raul.model.RaulUser;

public interface AuthService {

    public RaulUser loginUser (RaulUserLoginDto raulUserLoginDto);

    public RaulUser registerUser (RaulUserRegisterDto raulUserRegisterDto);
}
