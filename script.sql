USE [master]
GO
/****** Object:  Database [BIL372UI]    Script Date: 21.11.2021 23:55:30 ******/
CREATE DATABASE [BIL372UI]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BIL372UI', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BIL372UI.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BIL372UI_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BIL372UI_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BIL372UI] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BIL372UI].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BIL372UI] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BIL372UI] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BIL372UI] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BIL372UI] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BIL372UI] SET ARITHABORT OFF 
GO
ALTER DATABASE [BIL372UI] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BIL372UI] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BIL372UI] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BIL372UI] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BIL372UI] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BIL372UI] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BIL372UI] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BIL372UI] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BIL372UI] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BIL372UI] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BIL372UI] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BIL372UI] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BIL372UI] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BIL372UI] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BIL372UI] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BIL372UI] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BIL372UI] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BIL372UI] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BIL372UI] SET  MULTI_USER 
GO
ALTER DATABASE [BIL372UI] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BIL372UI] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BIL372UI] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BIL372UI] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BIL372UI] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BIL372UI] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BIL372UI] SET QUERY_STORE = OFF
GO
USE [BIL372UI]
GO
/****** Object:  Schema [BIL372UISCHEMA]    Script Date: 21.11.2021 23:55:30 ******/
CREATE SCHEMA [BIL372UISCHEMA]
GO
/****** Object:  Table [dbo].[Aktiviteler]    Script Date: 21.11.2021 23:55:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aktiviteler](
	[AktiviteID] [varchar](11) NOT NULL,
	[AktiviteTanimi] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AktiviteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Alanlar]    Script Date: 21.11.2021 23:55:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alanlar](
	[AlanID] [varchar](11) NOT NULL,
	[AlanAdi] [varchar](255) NOT NULL,
	[AlanTipi] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AlanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UC_Alanlar] UNIQUE NONCLUSTERED 
(
	[AlanAdi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Belirtecler]    Script Date: 21.11.2021 23:55:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Belirtecler](
	[BelirtecID] [varchar](11) NOT NULL,
	[BelirtecTanimi] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BelirtecID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Birimler]    Script Date: 21.11.2021 23:55:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Birimler](
	[BirimKodu] [varchar](255) NOT NULL,
	[BirimAdi] [varchar](255) NOT NULL,
	[UstBirimKodu] [varchar](255) NOT NULL,
	[BulunduguAdres] [varchar](255) NOT NULL,
	[IlKodu] [varchar](100) NOT NULL,
	[IlceKodu] [varchar](100) NOT NULL,
	[PostaKodu] [varchar](100) NOT NULL,
	[BirimMudurKullaniciAdi] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BirimKodu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CalisanProblem]    Script Date: 21.11.2021 23:55:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CalisanProblem](
	[ProblemID] [varchar](11) NOT NULL,
	[KullaniciAdi] [varchar](30) NOT NULL,
	[AlanID] [varchar](11) NOT NULL,
	[SinifID] [varchar](11) NOT NULL,
	[MudaheleID] [varchar](11) NOT NULL,
	[AktiviteID] [varchar](11) NOT NULL,
	[AktiviteAciklama] [varchar](255) NOT NULL,
	[Tarihi] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cikti]    Script Date: 21.11.2021 23:55:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cikti](
	[AlanID] [varchar](11) NOT NULL,
	[SinifID] [varchar](11) NOT NULL,
	[CiktiID] [varchar](11) NOT NULL,
	[CiktiAdi] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CiktiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CiktiDetay]    Script Date: 21.11.2021 23:55:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CiktiDetay](
	[AlanID] [varchar](11) NOT NULL,
	[SinifID] [varchar](11) NOT NULL,
	[CiktiID] [varchar](11) NOT NULL,
	[BelirtecID] [varchar](11) NOT NULL,
	[Sira] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IlaveCiktiDetay]    Script Date: 21.11.2021 23:55:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IlaveCiktiDetay](
	[AlanID] [varchar](11) NOT NULL,
	[SinifID] [varchar](11) NOT NULL,
	[MudaheleID] [varchar](11) NOT NULL,
	[ProblemID] [varchar](11) NOT NULL,
	[BelirtecID] [varchar](11) NOT NULL,
	[Sira] [int] NOT NULL,
	[EkleyenKullaniciAdi] [varchar](30) NOT NULL,
	[EklenmeTarihi] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IlaveMudahaleDetay]    Script Date: 21.11.2021 23:55:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IlaveMudahaleDetay](
	[AlanID] [varchar](11) NOT NULL,
	[SinifID] [varchar](11) NOT NULL,
	[MudaheleID] [varchar](11) NOT NULL,
	[ProblemID] [varchar](11) NOT NULL,
	[AktiviteID] [varchar](11) NOT NULL,
	[Sira] [int] NOT NULL,
	[EkleyenKullaniciAdi] [varchar](30) NOT NULL,
	[EklenmeTarihi] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ilceler]    Script Date: 21.11.2021 23:55:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ilceler](
	[IlKodu] [varchar](100) NOT NULL,
	[IlceKodu] [varchar](100) NOT NULL,
	[IlceAdi] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IlceKodu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Iller]    Script Date: 21.11.2021 23:55:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Iller](
	[IlKodu] [varchar](100) NOT NULL,
	[IlAdi] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IlKodu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanicilar]    Script Date: 21.11.2021 23:55:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanicilar](
	[KullaniciAdi] [varchar](30) NOT NULL,
	[Sifre] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[KullaniciAdi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mudahele]    Script Date: 21.11.2021 23:55:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mudahele](
	[AlanID] [varchar](11) NOT NULL,
	[SinifID] [varchar](11) NOT NULL,
	[MudaheleID] [varchar](11) NOT NULL,
	[MudaheleAdi] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MudaheleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MudaheleDetay]    Script Date: 21.11.2021 23:55:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MudaheleDetay](
	[AlanID] [varchar](11) NOT NULL,
	[SinifID] [varchar](11) NOT NULL,
	[MudaheleID] [varchar](11) NOT NULL,
	[AktiviteID] [varchar](11) NOT NULL,
	[Sira] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personel]    Script Date: 21.11.2021 23:55:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel](
	[KullaniciAdi] [varchar](30) NOT NULL,
	[Email] [varchar](255) NOT NULL,
	[Ad] [varchar](255) NOT NULL,
	[Soyad] [varchar](255) NOT NULL,
	[SicilNo] [varchar](255) NOT NULL,
	[Cep] [varchar](11) NOT NULL,
	[EvAdresi] [varchar](255) NOT NULL,
	[IlKodu] [varchar](100) NOT NULL,
	[IlceKodu] [varchar](100) NOT NULL,
	[PostaKodu] [varchar](100) NOT NULL,
	[UstKullaniciAdi] [varchar](255) NULL,
	[CalistigiBirimKodu] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SicilNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UC_Personel] UNIQUE NONCLUSTERED 
(
	[Email] ASC,
	[SicilNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonelProblem]    Script Date: 21.11.2021 23:55:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonelProblem](
	[ProblemID] [varchar](11) NOT NULL,
	[KullaniciAdi] [varchar](30) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Problem]    Script Date: 21.11.2021 23:55:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Problem](
	[ProblemTipiId] [varchar](11) NOT NULL,
	[ProblemTanimi] [varchar](255) NOT NULL,
	[ProblemiTanimlayiciAdi] [varchar](30) NOT NULL,
	[ProblemiTanimlayiciSoyadi] [varchar](30) NOT NULL,
	[ProblemiTanimlayanTCNOPasaportno] [varchar](100) NOT NULL,
	[HedeflenenAmacTanimi] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProblemTipiId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProblemBirim]    Script Date: 21.11.2021 23:55:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProblemBirim](
	[ProblemID] [varchar](11) NOT NULL,
	[BirimID] [varchar](255) NOT NULL,
	[EslesmeTarihi] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProblemCikti]    Script Date: 21.11.2021 23:55:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProblemCikti](
	[AlanID] [varchar](11) NOT NULL,
	[SinifID] [varchar](11) NOT NULL,
	[CiktiID] [varchar](11) NOT NULL,
	[ProblemID] [varchar](11) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProblemCiktiDegerlendirme]    Script Date: 21.11.2021 23:55:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProblemCiktiDegerlendirme](
	[ProblemID] [varchar](11) NOT NULL,
	[BelirtecID] [varchar](11) NOT NULL,
	[Skor] [int] NULL,
	[SkorTarihi] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProblemDurumDegerlendirme]    Script Date: 21.11.2021 23:55:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProblemDurumDegerlendirme](
	[ProblemID] [varchar](11) NOT NULL,
	[YeniProblemID] [varchar](11) NULL,
	[YeniProblemTanımı] [varchar](255) NULL,
	[YeniHedef] [varchar](100) NULL,
	[OncekiProblemSkoru] [int] NULL,
	[TahminEdilenProblemSkoru] [int] NULL,
	[DegerlendirenKullaniciAdi] [varchar](30) NOT NULL,
	[DegerlendirmeTarihi] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProblemMudahele]    Script Date: 21.11.2021 23:55:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProblemMudahele](
	[AlanID] [varchar](11) NOT NULL,
	[SinifID] [varchar](11) NOT NULL,
	[MudaheleID] [varchar](11) NOT NULL,
	[ProblemID] [varchar](11) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Siniflar]    Script Date: 21.11.2021 23:55:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Siniflar](
	[SinifID] [varchar](11) NOT NULL,
	[SinifAdi] [varchar](255) NOT NULL,
	[AlanTipi] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SinifID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UC_Siniflar] UNIQUE NONCLUSTERED 
(
	[SinifAdi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Birimler]  WITH CHECK ADD FOREIGN KEY([BirimMudurKullaniciAdi])
REFERENCES [dbo].[Kullanicilar] ([KullaniciAdi])
GO
ALTER TABLE [dbo].[Birimler]  WITH CHECK ADD FOREIGN KEY([IlceKodu])
REFERENCES [dbo].[Ilceler] ([IlceKodu])
GO
ALTER TABLE [dbo].[Birimler]  WITH CHECK ADD FOREIGN KEY([IlKodu])
REFERENCES [dbo].[Iller] ([IlKodu])
GO
ALTER TABLE [dbo].[CalisanProblem]  WITH CHECK ADD FOREIGN KEY([AktiviteID])
REFERENCES [dbo].[Aktiviteler] ([AktiviteID])
GO
ALTER TABLE [dbo].[CalisanProblem]  WITH CHECK ADD FOREIGN KEY([AlanID])
REFERENCES [dbo].[Alanlar] ([AlanID])
GO
ALTER TABLE [dbo].[CalisanProblem]  WITH CHECK ADD FOREIGN KEY([KullaniciAdi])
REFERENCES [dbo].[Kullanicilar] ([KullaniciAdi])
GO
ALTER TABLE [dbo].[CalisanProblem]  WITH CHECK ADD FOREIGN KEY([MudaheleID])
REFERENCES [dbo].[Mudahele] ([MudaheleID])
GO
ALTER TABLE [dbo].[CalisanProblem]  WITH CHECK ADD FOREIGN KEY([ProblemID])
REFERENCES [dbo].[Problem] ([ProblemTipiId])
GO
ALTER TABLE [dbo].[CalisanProblem]  WITH CHECK ADD FOREIGN KEY([SinifID])
REFERENCES [dbo].[Siniflar] ([SinifID])
GO
ALTER TABLE [dbo].[Cikti]  WITH CHECK ADD FOREIGN KEY([AlanID])
REFERENCES [dbo].[Alanlar] ([AlanID])
GO
ALTER TABLE [dbo].[Cikti]  WITH CHECK ADD FOREIGN KEY([SinifID])
REFERENCES [dbo].[Siniflar] ([SinifID])
GO
ALTER TABLE [dbo].[CiktiDetay]  WITH CHECK ADD FOREIGN KEY([AlanID])
REFERENCES [dbo].[Alanlar] ([AlanID])
GO
ALTER TABLE [dbo].[CiktiDetay]  WITH CHECK ADD FOREIGN KEY([BelirtecID])
REFERENCES [dbo].[Belirtecler] ([BelirtecID])
GO
ALTER TABLE [dbo].[CiktiDetay]  WITH CHECK ADD FOREIGN KEY([CiktiID])
REFERENCES [dbo].[Cikti] ([CiktiID])
GO
ALTER TABLE [dbo].[CiktiDetay]  WITH CHECK ADD FOREIGN KEY([SinifID])
REFERENCES [dbo].[Siniflar] ([SinifID])
GO
ALTER TABLE [dbo].[IlaveCiktiDetay]  WITH CHECK ADD FOREIGN KEY([AlanID])
REFERENCES [dbo].[Alanlar] ([AlanID])
GO
ALTER TABLE [dbo].[IlaveCiktiDetay]  WITH CHECK ADD FOREIGN KEY([BelirtecID])
REFERENCES [dbo].[Belirtecler] ([BelirtecID])
GO
ALTER TABLE [dbo].[IlaveCiktiDetay]  WITH CHECK ADD FOREIGN KEY([EkleyenKullaniciAdi])
REFERENCES [dbo].[Kullanicilar] ([KullaniciAdi])
GO
ALTER TABLE [dbo].[IlaveCiktiDetay]  WITH CHECK ADD FOREIGN KEY([MudaheleID])
REFERENCES [dbo].[Mudahele] ([MudaheleID])
GO
ALTER TABLE [dbo].[IlaveCiktiDetay]  WITH CHECK ADD FOREIGN KEY([ProblemID])
REFERENCES [dbo].[Problem] ([ProblemTipiId])
GO
ALTER TABLE [dbo].[IlaveCiktiDetay]  WITH CHECK ADD FOREIGN KEY([SinifID])
REFERENCES [dbo].[Siniflar] ([SinifID])
GO
ALTER TABLE [dbo].[IlaveMudahaleDetay]  WITH CHECK ADD FOREIGN KEY([AktiviteID])
REFERENCES [dbo].[Aktiviteler] ([AktiviteID])
GO
ALTER TABLE [dbo].[IlaveMudahaleDetay]  WITH CHECK ADD FOREIGN KEY([AlanID])
REFERENCES [dbo].[Alanlar] ([AlanID])
GO
ALTER TABLE [dbo].[IlaveMudahaleDetay]  WITH CHECK ADD FOREIGN KEY([EkleyenKullaniciAdi])
REFERENCES [dbo].[Kullanicilar] ([KullaniciAdi])
GO
ALTER TABLE [dbo].[IlaveMudahaleDetay]  WITH CHECK ADD FOREIGN KEY([MudaheleID])
REFERENCES [dbo].[Mudahele] ([MudaheleID])
GO
ALTER TABLE [dbo].[IlaveMudahaleDetay]  WITH CHECK ADD FOREIGN KEY([ProblemID])
REFERENCES [dbo].[Problem] ([ProblemTipiId])
GO
ALTER TABLE [dbo].[IlaveMudahaleDetay]  WITH CHECK ADD FOREIGN KEY([SinifID])
REFERENCES [dbo].[Siniflar] ([SinifID])
GO
ALTER TABLE [dbo].[Ilceler]  WITH CHECK ADD FOREIGN KEY([IlKodu])
REFERENCES [dbo].[Iller] ([IlKodu])
GO
ALTER TABLE [dbo].[Mudahele]  WITH CHECK ADD FOREIGN KEY([AlanID])
REFERENCES [dbo].[Alanlar] ([AlanID])
GO
ALTER TABLE [dbo].[Mudahele]  WITH CHECK ADD FOREIGN KEY([SinifID])
REFERENCES [dbo].[Siniflar] ([SinifID])
GO
ALTER TABLE [dbo].[MudaheleDetay]  WITH CHECK ADD FOREIGN KEY([AktiviteID])
REFERENCES [dbo].[Aktiviteler] ([AktiviteID])
GO
ALTER TABLE [dbo].[MudaheleDetay]  WITH CHECK ADD FOREIGN KEY([AlanID])
REFERENCES [dbo].[Alanlar] ([AlanID])
GO
ALTER TABLE [dbo].[MudaheleDetay]  WITH CHECK ADD FOREIGN KEY([MudaheleID])
REFERENCES [dbo].[Mudahele] ([MudaheleID])
GO
ALTER TABLE [dbo].[MudaheleDetay]  WITH CHECK ADD FOREIGN KEY([SinifID])
REFERENCES [dbo].[Siniflar] ([SinifID])
GO
ALTER TABLE [dbo].[Personel]  WITH CHECK ADD FOREIGN KEY([CalistigiBirimKodu])
REFERENCES [dbo].[Birimler] ([BirimKodu])
GO
ALTER TABLE [dbo].[Personel]  WITH CHECK ADD FOREIGN KEY([IlceKodu])
REFERENCES [dbo].[Ilceler] ([IlceKodu])
GO
ALTER TABLE [dbo].[Personel]  WITH CHECK ADD FOREIGN KEY([IlKodu])
REFERENCES [dbo].[Iller] ([IlKodu])
GO
ALTER TABLE [dbo].[Personel]  WITH CHECK ADD FOREIGN KEY([KullaniciAdi])
REFERENCES [dbo].[Kullanicilar] ([KullaniciAdi])
GO
ALTER TABLE [dbo].[PersonelProblem]  WITH CHECK ADD FOREIGN KEY([KullaniciAdi])
REFERENCES [dbo].[Kullanicilar] ([KullaniciAdi])
GO
ALTER TABLE [dbo].[PersonelProblem]  WITH CHECK ADD FOREIGN KEY([ProblemID])
REFERENCES [dbo].[Problem] ([ProblemTipiId])
GO
ALTER TABLE [dbo].[ProblemBirim]  WITH CHECK ADD FOREIGN KEY([BirimID])
REFERENCES [dbo].[Birimler] ([BirimKodu])
GO
ALTER TABLE [dbo].[ProblemBirim]  WITH CHECK ADD FOREIGN KEY([ProblemID])
REFERENCES [dbo].[Problem] ([ProblemTipiId])
GO
ALTER TABLE [dbo].[ProblemCikti]  WITH CHECK ADD FOREIGN KEY([AlanID])
REFERENCES [dbo].[Alanlar] ([AlanID])
GO
ALTER TABLE [dbo].[ProblemCikti]  WITH CHECK ADD FOREIGN KEY([CiktiID])
REFERENCES [dbo].[Cikti] ([CiktiID])
GO
ALTER TABLE [dbo].[ProblemCikti]  WITH CHECK ADD FOREIGN KEY([ProblemID])
REFERENCES [dbo].[Problem] ([ProblemTipiId])
GO
ALTER TABLE [dbo].[ProblemCikti]  WITH CHECK ADD FOREIGN KEY([SinifID])
REFERENCES [dbo].[Siniflar] ([SinifID])
GO
ALTER TABLE [dbo].[ProblemCiktiDegerlendirme]  WITH CHECK ADD FOREIGN KEY([BelirtecID])
REFERENCES [dbo].[Belirtecler] ([BelirtecID])
GO
ALTER TABLE [dbo].[ProblemCiktiDegerlendirme]  WITH CHECK ADD FOREIGN KEY([ProblemID])
REFERENCES [dbo].[Problem] ([ProblemTipiId])
GO
ALTER TABLE [dbo].[ProblemDurumDegerlendirme]  WITH CHECK ADD FOREIGN KEY([DegerlendirenKullaniciAdi])
REFERENCES [dbo].[Kullanicilar] ([KullaniciAdi])
GO
ALTER TABLE [dbo].[ProblemDurumDegerlendirme]  WITH CHECK ADD FOREIGN KEY([ProblemID])
REFERENCES [dbo].[Problem] ([ProblemTipiId])
GO
ALTER TABLE [dbo].[ProblemMudahele]  WITH CHECK ADD FOREIGN KEY([AlanID])
REFERENCES [dbo].[Alanlar] ([AlanID])
GO
ALTER TABLE [dbo].[ProblemMudahele]  WITH CHECK ADD FOREIGN KEY([MudaheleID])
REFERENCES [dbo].[Mudahele] ([MudaheleID])
GO
ALTER TABLE [dbo].[ProblemMudahele]  WITH CHECK ADD FOREIGN KEY([ProblemID])
REFERENCES [dbo].[Problem] ([ProblemTipiId])
GO
ALTER TABLE [dbo].[ProblemMudahele]  WITH CHECK ADD FOREIGN KEY([SinifID])
REFERENCES [dbo].[Siniflar] ([SinifID])
GO
ALTER TABLE [dbo].[ProblemCiktiDegerlendirme]  WITH CHECK ADD CHECK  (([Skor]>=(1) AND [Skor]<=(5)))
GO
ALTER TABLE [dbo].[ProblemDurumDegerlendirme]  WITH CHECK ADD CHECK  (([OncekiProblemSkoru]>=(1) AND [OncekiProblemSkoru]<=(5)))
GO
ALTER TABLE [dbo].[ProblemDurumDegerlendirme]  WITH CHECK ADD CHECK  (([TahminEdilenProblemSkoru]>=(1) AND [TahminEdilenProblemSkoru]<=(5)))
GO
USE [master]
GO
ALTER DATABASE [BIL372UI] SET  READ_WRITE 
GO
