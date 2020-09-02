using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace raul.Models.Db
{
    public partial class RaulDbContext : DbContext
    {
        public RaulDbContext()
        {
        }

        public RaulDbContext(DbContextOptions<RaulDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Age> Age { get; set; }
        public virtual DbSet<Award> Award { get; set; }
        public virtual DbSet<Competition> Competition { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Game> Game { get; set; }
        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<Pot> Pot { get; set; }
        public virtual DbSet<RaulUser> RaulUser { get; set; }
        public virtual DbSet<Season> Season { get; set; }
        public virtual DbSet<Team> Team { get; set; }
        public virtual DbSet<Universe> Universe { get; set; }
        public virtual DbSet<UniverseUser> UniverseUser { get; set; }

        // Unable to generate entity type for table 'dbo.Team_Pot'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Raul;Integrated Security=SSPI;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Age>(entity =>
            {
                entity.HasKey(e => new { e.Age1, e.UniverseId });

                entity.Property(e => e.Age1).HasColumnName("age");

                entity.Property(e => e.UniverseId).HasColumnName("universe_id");

                entity.Property(e => e.BallonDeOrWinnerUsername)
                    .HasColumnName("ballon_de_or_winner_username")
                    .HasMaxLength(100);

                entity.Property(e => e.MediaDescription).HasColumnName("media_description");

                entity.Property(e => e.MediaName)
                    .HasColumnName("media_name")
                    .HasMaxLength(100);

                entity.Property(e => e.PesVersion)
                    .HasColumnName("pes_version")
                    .HasMaxLength(100);

                entity.HasOne(d => d.BallonDeOrWinnerUsernameNavigation)
                    .WithMany(p => p.Age)
                    .HasForeignKey(d => d.BallonDeOrWinnerUsername)
                    .HasConstraintName("FK__Age__ballon_de_o__2DB1C7EE");

                entity.HasOne(d => d.Universe)
                    .WithMany(p => p.Age)
                    .HasForeignKey(d => d.UniverseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Age__universe_id__2CBDA3B5");
            });

            modelBuilder.Entity<Award>(entity =>
            {
                entity.HasKey(e => e.AwardName);

                entity.Property(e => e.AwardName)
                    .HasColumnName("award_name")
                    .HasMaxLength(100)
                    .ValueGeneratedNever();

                entity.Property(e => e.IsOfficialAward).HasColumnName("is_official_award");

                entity.Property(e => e.MediaDescription).HasColumnName("media_description");

                entity.Property(e => e.OfficialDescription).HasColumnName("official_description");

                entity.Property(e => e.WinnerRaulUUsername)
                    .HasColumnName("winner_raul_u_username")
                    .HasMaxLength(100);

                entity.HasOne(d => d.WinnerRaulUUsernameNavigation)
                    .WithMany(p => p.Award)
                    .HasForeignKey(d => d.WinnerRaulUUsername)
                    .HasConstraintName("FK__Award__winner_ra__6501FCD8");
            });

            modelBuilder.Entity<Competition>(entity =>
            {
                entity.HasKey(e => new { e.UniverseId, e.ComptName, e.Edition });

                entity.Property(e => e.UniverseId).HasColumnName("universe_id");

                entity.Property(e => e.ComptName)
                    .HasColumnName("compt_name")
                    .HasMaxLength(100);

                entity.Property(e => e.Edition).HasColumnName("edition");

                entity.Property(e => e.Alias)
                    .HasColumnName("alias")
                    .HasMaxLength(100);

                entity.Property(e => e.History).HasColumnName("history");

                entity.Property(e => e.IsOfficialCompetition).HasColumnName("is_official_competition");

                entity.Property(e => e.Rules).HasColumnName("rules");

                entity.Property(e => e.WinnerId)
                    .HasColumnName("winner_id")
                    .HasMaxLength(100);

                entity.HasOne(d => d.Universe)
                    .WithMany(p => p.Competition)
                    .HasForeignKey(d => d.UniverseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Competiti__unive__40C49C62");

                entity.HasOne(d => d.Winner)
                    .WithMany(p => p.Competition)
                    .HasForeignKey(d => d.WinnerId)
                    .HasConstraintName("FK__Competiti__winne__41B8C09B");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.CountryName);

                entity.Property(e => e.CountryName)
                    .HasColumnName("country_name")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Game>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AwayRaulUUsername)
                    .IsRequired()
                    .HasColumnName("away_raul_u_username")
                    .HasMaxLength(100);

                entity.Property(e => e.AwayScore).HasColumnName("away_score");

                entity.Property(e => e.AwayTeam)
                    .IsRequired()
                    .HasColumnName("away_team")
                    .HasMaxLength(100);

                entity.Property(e => e.CompetitionEdition).HasColumnName("competition_edition");

                entity.Property(e => e.CompetitionName)
                    .IsRequired()
                    .HasColumnName("competition_name")
                    .HasMaxLength(100);

                entity.Property(e => e.CompetitionRound).HasColumnName("competition_round");

                entity.Property(e => e.HomeRaulUUsername)
                    .IsRequired()
                    .HasColumnName("home_raul_u_username")
                    .HasMaxLength(100);

                entity.Property(e => e.HomeScore).HasColumnName("home_score");

                entity.Property(e => e.HomeTeam)
                    .IsRequired()
                    .HasColumnName("home_team")
                    .HasMaxLength(100);

                entity.Property(e => e.IsOver).HasColumnName("is_over");

                entity.Property(e => e.PlayedDate)
                    .HasColumnName("played_date")
                    .HasColumnType("date");

                entity.Property(e => e.PotName)
                    .IsRequired()
                    .HasColumnName("pot_name")
                    .HasMaxLength(100);

                entity.Property(e => e.UniverseId).HasColumnName("universe_id");

                entity.HasOne(d => d.AwayRaulUUsernameNavigation)
                    .WithMany(p => p.GameAwayRaulUUsernameNavigation)
                    .HasForeignKey(d => d.AwayRaulUUsername)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Game__away_raul___5C37ACAD");

                entity.HasOne(d => d.AwayTeamNavigation)
                    .WithMany(p => p.GameAwayTeamNavigation)
                    .HasForeignKey(d => d.AwayTeam)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Game__away_team__5D2BD0E6");

                entity.HasOne(d => d.HomeRaulUUsernameNavigation)
                    .WithMany(p => p.GameHomeRaulUUsernameNavigation)
                    .HasForeignKey(d => d.HomeRaulUUsername)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Game__home_raul___5A4F643B");

                entity.HasOne(d => d.HomeTeamNavigation)
                    .WithMany(p => p.GameHomeTeamNavigation)
                    .HasForeignKey(d => d.HomeTeam)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Game__home_team__5B438874");

                entity.HasOne(d => d.Pot)
                    .WithMany(p => p.Game)
                    .HasForeignKey(d => new { d.PotName, d.UniverseId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Game__5F141958");

                entity.HasOne(d => d.Competition)
                    .WithMany(p => p.Game)
                    .HasForeignKey(d => new { d.UniverseId, d.CompetitionName, d.CompetitionEdition })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Game__5E1FF51F");
            });

            modelBuilder.Entity<Player>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FullName)
                    .HasColumnName("full_name")
                    .HasMaxLength(100);

                entity.Property(e => e.TeamName)
                    .HasColumnName("team_name")
                    .HasMaxLength(100);

                entity.HasOne(d => d.TeamNameNavigation)
                    .WithMany(p => p.Player)
                    .HasForeignKey(d => d.TeamName)
                    .HasConstraintName("FK__Player__team_nam__0880433F");
            });

            modelBuilder.Entity<Pot>(entity =>
            {
                entity.HasKey(e => new { e.PotName, e.UniverseId });

                entity.Property(e => e.PotName)
                    .HasColumnName("pot_name")
                    .HasMaxLength(100);

                entity.Property(e => e.UniverseId).HasColumnName("universe_id");

                entity.Property(e => e.IsOfficialPot).HasColumnName("is_official_pot");

                entity.Property(e => e.MediaDescription)
                    .HasColumnName("media_description")
                    .HasMaxLength(200);

                entity.Property(e => e.PotDescription)
                    .HasColumnName("pot_description")
                    .HasMaxLength(200);

                entity.HasOne(d => d.Universe)
                    .WithMany(p => p.Pot)
                    .HasForeignKey(d => d.UniverseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Pot__universe_id__44952D46");
            });

            modelBuilder.Entity<RaulUser>(entity =>
            {
                entity.HasKey(e => e.Username);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(100)
                    .ValueGeneratedNever();

                entity.Property(e => e.FavPlayerId).HasColumnName("fav_player_id");

                entity.Property(e => e.MediaFavTeam)
                    .HasColumnName("media_fav_team")
                    .HasMaxLength(100);

                entity.Property(e => e.MediaRivalTeam)
                    .HasColumnName("media_rival_team")
                    .HasMaxLength(100);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password");

                entity.Property(e => e.PesFavTeam)
                    .HasColumnName("pes_fav_team")
                    .HasMaxLength(100);

                entity.Property(e => e.RivalTeam)
                    .HasColumnName("rival_team")
                    .HasMaxLength(100);

                entity.Property(e => e.RlFavTeam)
                    .HasColumnName("rl_fav_team")
                    .HasMaxLength(100);

                entity.HasOne(d => d.FavPlayer)
                    .WithMany(p => p.RaulUser)
                    .HasForeignKey(d => d.FavPlayerId)
                    .HasConstraintName("FK__RaulUser__fav_pl__2610A626");

                entity.HasOne(d => d.MediaFavTeamNavigation)
                    .WithMany(p => p.RaulUserMediaFavTeamNavigation)
                    .HasForeignKey(d => d.MediaFavTeam)
                    .HasConstraintName("FK__RaulUser__media___24285DB4");

                entity.HasOne(d => d.MediaRivalTeamNavigation)
                    .WithMany(p => p.RaulUserMediaRivalTeamNavigation)
                    .HasForeignKey(d => d.MediaRivalTeam)
                    .HasConstraintName("FK__RaulUser__media___251C81ED");

                entity.HasOne(d => d.PesFavTeamNavigation)
                    .WithMany(p => p.RaulUserPesFavTeamNavigation)
                    .HasForeignKey(d => d.PesFavTeam)
                    .HasConstraintName("FK__RaulUser__pes_fa__22401542");

                entity.HasOne(d => d.RivalTeamNavigation)
                    .WithMany(p => p.RaulUserRivalTeamNavigation)
                    .HasForeignKey(d => d.RivalTeam)
                    .HasConstraintName("FK__RaulUser__rival___2334397B");

                entity.HasOne(d => d.RlFavTeamNavigation)
                    .WithMany(p => p.RaulUserRlFavTeamNavigation)
                    .HasForeignKey(d => d.RlFavTeam)
                    .HasConstraintName("FK__RaulUser__rl_fav__214BF109");
            });

            modelBuilder.Entity<Season>(entity =>
            {
                entity.HasKey(e => new { e.SeasonNumber, e.Age });

                entity.Property(e => e.SeasonNumber).HasColumnName("season_number");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.MediaDescription).HasColumnName("media_description");

                entity.Property(e => e.PesVersion).HasColumnName("pes_version");

                entity.Property(e => e.PlayerOfTheYearId)
                    .HasColumnName("player_of_the_year_id")
                    .HasMaxLength(100);

                entity.Property(e => e.SeasonHistory).HasColumnName("season_history");

                entity.Property(e => e.UniverseId).HasColumnName("universe_id");

                entity.HasOne(d => d.PlayerOfTheYear)
                    .WithMany(p => p.Season)
                    .HasForeignKey(d => d.PlayerOfTheYearId)
                    .HasConstraintName("FK__Season__player_o__39237A9A");

                entity.HasOne(d => d.AgeNavigation)
                    .WithMany(p => p.Season)
                    .HasForeignKey(d => new { d.Age, d.UniverseId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Season__3A179ED3");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.HasKey(e => e.TeamName);

                entity.HasIndex(e => e.Initials)
                    .HasName("UQ__Team__696DB02C9A017446")
                    .IsUnique();

                entity.HasIndex(e => e.Supporters)
                    .HasName("UQ__Team__8C585C043F256002")
                    .IsUnique();

                entity.Property(e => e.TeamName)
                    .HasColumnName("team_name")
                    .HasMaxLength(100)
                    .ValueGeneratedNever();

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(50);

                entity.Property(e => e.Initials)
                    .IsRequired()
                    .HasColumnName("initials")
                    .HasMaxLength(10);

                entity.Property(e => e.IsNationalTeam).HasColumnName("is_national_team");

                entity.Property(e => e.Supporters)
                    .IsRequired()
                    .HasColumnName("supporters")
                    .HasMaxLength(100);

                entity.HasOne(d => d.CountryNavigation)
                    .WithMany(p => p.Team)
                    .HasForeignKey(d => d.Country)
                    .HasConstraintName("FK__Team__country__02C769E9");
            });

            modelBuilder.Entity<Universe>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasColumnName("alias")
                    .HasMaxLength(100);

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("date");

                entity.Property(e => e.History).HasColumnName("history");
            });

            modelBuilder.Entity<UniverseUser>(entity =>
            {
                entity.HasKey(e => new { e.UniverseId, e.RaulUsername });

                entity.ToTable("Universe_User");

                entity.Property(e => e.UniverseId).HasColumnName("universe_id");

                entity.Property(e => e.RaulUsername)
                    .HasColumnName("raul_username")
                    .HasMaxLength(100);

                entity.HasOne(d => d.RaulUsernameNavigation)
                    .WithMany(p => p.UniverseUser)
                    .HasForeignKey(d => d.RaulUsername)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Universe___raul___6E565CE8");

                entity.HasOne(d => d.Universe)
                    .WithMany(p => p.UniverseUser)
                    .HasForeignKey(d => d.UniverseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Universe___unive__6D6238AF");
            });
        }
    }
}
