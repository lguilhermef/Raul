package queen.talls.raul.service;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import queen.talls.raul.model.Universe;
import queen.talls.raul.repository.TestRepository;
import queen.talls.raul.repository.UniverseRepository;

@Service
public class UniverseServiceImpl implements UniverseService {

    @Autowired
    private UniverseRepository uRepo;
    @Autowired
    private TestRepository tRepo;

    public UniverseServiceImpl(UniverseRepository uRepo, TestRepository tRepo) {
        this.uRepo = uRepo;
        this.tRepo = tRepo;
    }

    public Universe addUniverse() {

            Universe universe = new Universe();
        try {

            universe.setName("test");
            universe.setHistory("tessst");
            uRepo.save(universe);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
            return universe;
    }
}
