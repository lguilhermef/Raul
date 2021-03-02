package queen.talls.raul.model;

import javax.persistence.*;
import java.util.Date;

@Entity
@Table
public class Universe {

    @Id
    private int id;
    private String name;
    private String history;
    //@Temporal(TemporalType.TIMESTAMP)
    @Column(name="creation_date")
    private Date creationDate;

    public int getId() {
        return this.id;
    }

    public String getName() {
        return this.name;
    }

    public String getHistory(){
        return this.history;
    }

    public void setId(int id){
       this.id = id;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setHistory(String history) {
        this.history = history;
    }

    public void setCreationDate(Date creationDate) {
        this.creationDate = creationDate;
    }
}
