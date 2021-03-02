package queen.talls.raul.repository;

import org.springframework.data.repository.CrudRepository;
import queen.talls.raul.model.RaulUser;

public interface RaulUserRepository extends CrudRepository<RaulUser, String> {

    //public RaulUser getUser(String username);
}
