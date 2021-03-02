package queen.talls.raul.model.dto;

import queen.talls.raul.model.RaulUser;

public class RaulUserDto {


    private String username;
    private String realLifeFavoriteTeam;
    private String pesFavoriteTeam;
    private String rivalTeam;
    private String mediaFavoriteTeam;
    private String mediaRivalTeam;
    private Integer favPlayerId;


    public RaulUserDto () {

    }

    public RaulUserDto (RaulUser raulUser) {

        this.username = raulUser.getUsername();
        this.realLifeFavoriteTeam = raulUser.getRealLifeFavoriteTeam();
        this.pesFavoriteTeam = raulUser.getPesFavoriteTeam();
        this.rivalTeam = raulUser.getRivalTeam();
        this.mediaFavoriteTeam = raulUser.getMediaRivalTeam();
        this.mediaRivalTeam = raulUser.getMediaRivalTeam();
        this.favPlayerId = raulUser.getFavPlayerId();
    }
}
