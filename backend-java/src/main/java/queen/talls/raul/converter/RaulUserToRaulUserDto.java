package queen.talls.raul.converter;

import queen.talls.raul.model.RaulUser;
import queen.talls.raul.model.dto.RaulUserDto;

public class RaulUserToRaulUserDto implements RaulConverter<RaulUser, RaulUserDto> {


    @Override
    public RaulUserDto convert(RaulUser raulUser) {

        return new RaulUserDto(raulUser);
    }
}
