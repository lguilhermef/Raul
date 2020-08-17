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
        public virtual DbSet<Game> Game { get; set; }
        public virtual DbSet<Goal> Goal { get; set; }
        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<Pot> Pot { get; set; }
        public virtual DbSet<RaulUser> RaulUser { get; set; }
        public virtual DbSet<Season> Season { get; set; }
        public virtual DbSet<Team> Team { get; set; }
        public virtual DbSet<Universe> Universe { get; set; }

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
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BallonDeOrWinnerId).HasColumnName("ballonDeOrWinnerId");

                entity.Property(e => e.CsvPesVersion)
                    .HasColumnName("csvPesVersion")
                    .HasMaxLength(100);

                entity.Property(e => e.CsvSeason).HasColumnName("csvSeason");

                entity.Property(e => e.NvcMediaDescription).HasColumnName("nvcMediaDescription");

                entity.Property(e => e.NvcName)
                    .HasColumnName("nvcName")
                    .HasMaxLength(100);

                entity.HasOne(d => d.BallonDeOrWinner)
                    .WithMany(p => p.Age)
                    .HasForeignKey(d => d.BallonDeOrWinnerId)
                    .HasConstraintName("FK__Age__ballonDeOrW__208CD6FA");
            });

            modelBuilder.Entity<Award>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NvcDescription)
                    .HasColumnName("nvcDescription")
                    .HasMaxLength(100);

                entity.Property(e => e.NvcMediaDescription)
                    .HasColumnName("nvcMediaDescription")
                    .HasMaxLength(100);

                entity.Property(e => e.NvcName)
                    .HasColumnName("nvcName")
                    .HasMaxLength(100);

                entity.Property(e => e.RaulUserWinnerId).HasColumnName("raulUserWinnerId");
            });

            modelBuilder.Entity<Competition>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CsvAward)
                    .HasColumnName("csvAward")
                    .HasMaxLength(50);

                entity.Property(e => e.CsvGame).HasColumnName("csvGame");

                entity.Property(e => e.Edition).HasColumnName("edition");

                entity.Property(e => e.NvcDescription).HasColumnName("nvcDescription");

                entity.Property(e => e.NvcName)
                    .HasColumnName("nvcName")
                    .HasMaxLength(100);

                entity.Property(e => e.ValueForSeason).HasColumnName("valueForSeason");

                entity.Property(e => e.WinnerId).HasColumnName("winnerId");

                entity.HasOne(d => d.Winner)
                    .WithMany(p => p.Competition)
                    .HasForeignKey(d => d.WinnerId)
                    .HasConstraintName("FK__Competiti__winne__19DFD96B");
            });

            modelBuilder.Entity<Game>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AwayRaulUserId).HasColumnName("awayRaulUserId");

                entity.Property(e => e.AwayScore).HasColumnName("awayScore");

                entity.Property(e => e.AwayTeamId).HasColumnName("awayTeamId");

                entity.Property(e => e.HomeRaulUserId).HasColumnName("homeRaulUserId");

                entity.Property(e => e.HomeScore).HasColumnName("homeScore");

                entity.Property(e => e.HomeTeamId).HasColumnName("homeTeamId");

                entity.Property(e => e.IsOver).HasColumnName("isOver");

                entity.HasOne(d => d.AwayRaulUser)
                    .WithMany(p => p.GameAwayRaulUser)
                    .HasForeignKey(d => d.AwayRaulUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Game__awayRaulUs__160F4887");

                entity.HasOne(d => d.AwayTeam)
                    .WithMany(p => p.GameAwayTeam)
                    .HasForeignKey(d => d.AwayTeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Game__awayTeamId__17036CC0");

                entity.HasOne(d => d.HomeRaulUser)
                    .WithMany(p => p.GameHomeRaulUser)
                    .HasForeignKey(d => d.HomeRaulUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Game__homeRaulUs__14270015");

                entity.HasOne(d => d.HomeTeam)
                    .WithMany(p => p.GameHomeTeam)
                    .HasForeignKey(d => d.HomeTeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Game__homeTeamId__151B244E");
            });

            modelBuilder.Entity<Goal>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AssisId).HasColumnName("assisId");

                entity.Property(e => e.GameId).HasColumnName("gameId");

                entity.Property(e => e.IntGamePart).HasColumnName("intGamePart");

                entity.Property(e => e.IntGoalTime).HasColumnName("intGoalTime");

                entity.Property(e => e.RaulUserId).HasColumnName("raulUserId");

                entity.Property(e => e.ScorerId).HasColumnName("scorerId");

                entity.Property(e => e.TeamId).HasColumnName("teamId");

                entity.HasOne(d => d.Assis)
                    .WithMany(p => p.GoalAssis)
                    .HasForeignKey(d => d.AssisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Goal__assisId__2645B050");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.Goal)
                    .HasForeignKey(d => d.GameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Goal__gameId__2739D489");

                entity.HasOne(d => d.RaulUser)
                    .WithMany(p => p.Goal)
                    .HasForeignKey(d => d.RaulUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Goal__raulUserId__236943A5");

                entity.HasOne(d => d.Scorer)
                    .WithMany(p => p.GoalScorer)
                    .HasForeignKey(d => d.ScorerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Goal__scorerId__25518C17");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.Goal)
                    .HasForeignKey(d => d.TeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Goal__teamId__245D67DE");
            });

            modelBuilder.Entity<Player>(entity =>
            {
                entity.HasIndex(e => e.NvcFullName)
                    .HasName("UQ__Player__9EA36277740D5F77")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NvcFullName)
                    .IsRequired()
                    .HasColumnName("nvcFullName")
                    .HasMaxLength(100);

                entity.Property(e => e.TeamId).HasColumnName("teamId");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.Player)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("FK__Player__teamId__08B54D69");
            });

            modelBuilder.Entity<Pot>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CsvTeamId)
                    .HasColumnName("csvTeamId")
                    .HasMaxLength(100);

                entity.Property(e => e.NvcDescription)
                    .HasColumnName("nvcDescription")
                    .HasMaxLength(100);

                entity.Property(e => e.NvcMediaDescription)
                    .HasColumnName("nvcMediaDescription")
                    .HasMaxLength(100);

                entity.Property(e => e.NvcName)
                    .HasColumnName("nvcName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<RaulUser>(entity =>
            {
                entity.ToTable("RaulUSer");

                entity.HasIndex(e => e.NvcUsername)
                    .HasName("UQ__RaulUSer__F9A7CFF08BFF4206")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FavTeamId).HasColumnName("favTeamId");

                entity.Property(e => e.MediaFavTeamId).HasColumnName("mediaFavTeamId");

                entity.Property(e => e.MediaRivalTeamId).HasColumnName("mediaRivalTeamId");

                entity.Property(e => e.NvcUsername)
                    .IsRequired()
                    .HasColumnName("nvcUsername")
                    .HasMaxLength(100);

                entity.Property(e => e.RivalTeamId).HasColumnName("rivalTeamId");

                entity.Property(e => e.RlFavPlayerId).HasColumnName("rlFavPlayerId");

                entity.Property(e => e.RlFavteamId).HasColumnName("rlFavteamId");

                entity.HasOne(d => d.FavTeam)
                    .WithMany(p => p.RaulUserFavTeam)
                    .HasForeignKey(d => d.FavTeamId)
                    .HasConstraintName("FK__RaulUSer__favTea__0D7A0286");

                entity.HasOne(d => d.MediaFavTeam)
                    .WithMany(p => p.RaulUserMediaFavTeam)
                    .HasForeignKey(d => d.MediaFavTeamId)
                    .HasConstraintName("FK__RaulUSer__mediaF__0F624AF8");

                entity.HasOne(d => d.MediaRivalTeam)
                    .WithMany(p => p.RaulUserMediaRivalTeam)
                    .HasForeignKey(d => d.MediaRivalTeamId)
                    .HasConstraintName("FK__RaulUSer__mediaR__10566F31");

                entity.HasOne(d => d.RivalTeam)
                    .WithMany(p => p.RaulUserRivalTeam)
                    .HasForeignKey(d => d.RivalTeamId)
                    .HasConstraintName("FK__RaulUSer__rivalT__0E6E26BF");

                entity.HasOne(d => d.RlFavPlayer)
                    .WithMany(p => p.RaulUser)
                    .HasForeignKey(d => d.RlFavPlayerId)
                    .HasConstraintName("FK__RaulUSer__rlFavP__114A936A");

                entity.HasOne(d => d.RlFavteam)
                    .WithMany(p => p.RaulUserRlFavteam)
                    .HasForeignKey(d => d.RlFavteamId)
                    .HasConstraintName("FK__RaulUSer__rlFavt__0C85DE4D");
            });

            modelBuilder.Entity<Season>(entity =>
            {
                entity.HasIndex(e => e.IntYear)
                    .HasName("UQ__Season__7475CC407CE08AAF")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CsvAward)
                    .HasColumnName("csvAward")
                    .HasMaxLength(50);

                entity.Property(e => e.CsvCompetition).HasColumnName("csvCompetition");

                entity.Property(e => e.IntPesVersion).HasColumnName("intPesVersion");

                entity.Property(e => e.IntYear).HasColumnName("intYear");

                entity.Property(e => e.NvcDescription).HasColumnName("nvcDescription");

                entity.Property(e => e.NvcMediaDescription).HasColumnName("nvcMediaDescription");

                entity.Property(e => e.PlayerOfTheYearWinnerId).HasColumnName("playerOfTheYearWinnerId");

                entity.HasOne(d => d.PlayerOfTheYearWinner)
                    .WithMany(p => p.Season)
                    .HasForeignKey(d => d.PlayerOfTheYearWinnerId)
                    .HasConstraintName("FK__Season__playerOf__1DB06A4F");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.HasIndex(e => e.NvcAlias)
                    .HasName("UQ__Team__1C83A9972F8CE1CE")
                    .IsUnique();

                entity.HasIndex(e => e.NvcInitials)
                    .HasName("UQ__Team__C59EED0D5860EE72")
                    .IsUnique();

                entity.HasIndex(e => e.NvcOfficialName)
                    .HasName("UQ__Team__CD42D040002B2E44")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BitNationalTeam).HasColumnName("bitNationalTeam");

                entity.Property(e => e.NvcAlias)
                    .IsRequired()
                    .HasColumnName("nvcAlias")
                    .HasMaxLength(100);

                entity.Property(e => e.NvcInitials)
                    .IsRequired()
                    .HasColumnName("nvcInitials")
                    .HasMaxLength(10);

                entity.Property(e => e.NvcOfficialName)
                    .IsRequired()
                    .HasColumnName("nvcOfficialName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Universe>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CsvAge)
                    .HasColumnName("csvAge")
                    .HasMaxLength(200);

                entity.Property(e => e.CsvRaulUser)
                    .HasColumnName("csvRaulUser")
                    .HasMaxLength(50);
            });
        }
    }
}
