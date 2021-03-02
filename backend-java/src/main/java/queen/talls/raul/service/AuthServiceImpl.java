package queen.talls.raul.service;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import queen.talls.raul.model.dto.RaulUserLoginDto;
import queen.talls.raul.model.dto.RaulUserRegisterDto;
import queen.talls.raul.model.RaulUser;
import queen.talls.raul.repository.RaulUserRepository;
import queen.talls.raul.utility.Cryptography;

import java.util.Optional;

@Service
public class AuthServiceImpl implements AuthService {

    @Autowired
    private RaulUserRepository raulUserRepository;


    @Override
    public RaulUser loginUser(RaulUserLoginDto raulUserLoginDto) {

        boolean isPassCorrect = false;
        Optional<RaulUser> optRaulUser = raulUserRepository.findById(raulUserLoginDto.getUsername());
        RaulUser raulUser = optRaulUser.orElse(null);

        if (raulUser != null) {
            isPassCorrect = Cryptography.verifyPassword(raulUserLoginDto.getPassword(), raulUser.getPasswordHash(), raulUser.getSalt());
        }

        return isPassCorrect ? raulUser : null;
    }

    @Override
    public RaulUser registerUser(RaulUserRegisterDto raulUserRegisterDto) {

        String salt = Cryptography.generateSalt();
        Optional<String> optHashedPassword = Cryptography.hashPassword(raulUserRegisterDto.getPassword(), salt);
        String hashedPassword = optHashedPassword.orElse(null);

        if (hashedPassword == null) {
            return null;
        }

        RaulUser raulUser = new RaulUser(raulUserRegisterDto.getUsername(), hashedPassword, salt);
        RaulUser persistedRaulUser = raulUserRepository.save(raulUser);

        return persistedRaulUser;
    }

    public boolean validateLoginData(RaulUser raulUser, RaulUserLoginDto raulUserLoginDto) {

        String insertedPasswordHash = "";

        try {
            System.out.println("AuthServiceImpl - Inside validateLoginData()");
            insertedPasswordHash = Cryptography.generateHash(raulUserLoginDto.getPassword());
            System.out.println(insertedPasswordHash);
            System.out.println(raulUser.getPasswordHash());

        } catch (Exception e) {
            System.out.println(e);
        }

        return raulUser.getPasswordHash() == insertedPasswordHash;
    }

    public String hashInput(String input) {

        String hashedInput = null;

        try {

            hashedInput = Cryptography.generateHash(input);

        } catch (Exception e) {
            System.out.println(e);
        }

        return hashedInput;
    }
}
