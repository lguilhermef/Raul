package queen.talls.raul.model;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name = "rauluser")
public class RaulUser {


    @Id
    private String username;
    @Column(name="password")
    private String passwordHash;
    private String salt;
    @Column(name = "rl_fav_team")
    private String realLifeFavoriteTeam;
    @Column(name = "pes_fav_team")
    private String pesFavoriteTeam;
    @Column(name = "rival_team")
    private String rivalTeam;
    @Column(name = "media_fav_team")
    private String mediaFavoriteTeam;
    @Column(name = "media_rival_team")
    private String mediaRivalTeam;
    @Column(name = "fav_player_id", nullable = true)
    private Integer favPlayerId;


    public RaulUser () {

    }

    public RaulUser (String username, String hashedPassword, String salt) {

        this.username = username;
        this.passwordHash = hashedPassword;
        this.salt = salt;
    }


    public String getUsername() {
        return username;
    }

    public String getPasswordHash() {
        return passwordHash;
    }

    public String getSalt () {
        return salt;
    }

    public String getRealLifeFavoriteTeam() {
        return realLifeFavoriteTeam;
    }

    public String getPesFavoriteTeam() {
        return pesFavoriteTeam;
    }

    public String getRivalTeam() {
        return rivalTeam;
    }

    public String getMediaFavoriteTeam() {
        return mediaFavoriteTeam;
    }

    public String getMediaRivalTeam() {
        return mediaRivalTeam;
    }

    public Integer getFavPlayerId() {
        return favPlayerId;
    }

    public void setUsername(String username) {
        this.username = username;
    }

    public void setSalt(String salt) {
        this.salt = salt;
    }

    public void setPasswordHash(String passwordHash) {
        this.passwordHash = passwordHash;
    }

    public void setRealLifeFavoriteTeam(String realLifeFavoriteTeam) {
        this.realLifeFavoriteTeam = realLifeFavoriteTeam;
    }

    public void setPesFavoriteTeam(String pesFavoriteTeam) {
        this.pesFavoriteTeam = pesFavoriteTeam;
    }

    public void setRivalTeam(String rivalTeam) {
        this.rivalTeam = rivalTeam;
    }

    public void setMediaFavoriteTeam(String mediaFavoriteTeam) {
        this.mediaFavoriteTeam = mediaFavoriteTeam;
    }

    public void setMediaRivalTeam(String mediaRivalTeam) {
        this.mediaRivalTeam = mediaRivalTeam;
    }

    public void setFavPlayerId(Integer favPlayerId) {
        this.favPlayerId = favPlayerId;
    }
}
