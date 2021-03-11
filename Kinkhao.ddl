-- *********************************************
-- * Standard SQL generation                   
-- *--------------------------------------------
-- * DB-MAIN version: 11.0.1              
-- * Generator date: Dec  4 2018              
-- * Generation date: Mon Aug 31 11:42:00 2020 
-- * LUN file: C:\Users\angel\Documents\DB-Main\KinhaoDB\Kinkhao.lun 
-- * Schema: RestarurantNoRel/1 
-- ********************************************* 


-- Database Section
-- ________________ 

create database RestarurantNoRel;


-- DBSpace Section
-- _______________


-- Tables Section
-- _____________ 

create table CAMERIERE (
     Codice Fiscale char(16) not null,
     Nome char(15) not null,
     Cognome char(20) not null,
     Genere char(1) not null,
     Telefono numeric(11) not null,
     Indirizzo char(20) not null,
     E-Mail -- Compound attribute -- not null,
     Data di Nascita date not null,
     constraint IDCAMERIERE_ID primary key (Codice Fiscale));

create table CASSIERE (
     Codice Fiscale char(16) not null,
     Nome char(15) not null,
     Cognome char(20) not null,
     Genere char(1) not null,
     Telefono numeric(11) not null,
     Indirizzo char(20) not null,
     E-Mail -- Compound attribute -- not null,
     Data di Nascita date not null,
     constraint IDCASSIERE_ID primary key (Codice Fiscale));

create table CLIENTE (
     Numero di Telefono numeric(11) not null,
     Nome char(15) not null,
     Cognome char(20) not null,
     constraint IDCLIENTE_ID primary key (Numero di Telefono));

create table CONTRATTO (
     Codice Contratto numeric(10) not null,
     Data Inizio date not null,
     Stipendio numeric(5,2) not null,
     Data Fine date,
     Cuoco_Codice Fiscale char(16),
     Cassiere_Codice Fiscale char(16),
     Cameriere_Codice Fiscale char(16),
     constraint IDCONTRATTO primary key (Codice Contratto, Data Inizio));

create table CUOCO (
     Codice Fiscale char(16) not null,
     Nome char(15) not null,
     Cognome char(20) not null,
     Genere char(1) not null,
     Telefono numeric(11) not null,
     Indirizzo char(20) not null,
     E-Mail -- Compound attribute -- not null,
     Data di Nascita date not null,
     constraint IDCUOCO_ID primary key (Codice Fiscale));

create table DDT (
     P.IVA varchar(11) not null,
     Anno char(4) not null,
     Numero char(3) not null,
     Data partenza date not null,
     Luogo partenza char(5) not null,
     Data consegna date not null,
     Corriere char(2),
     constraint IDDDT_ID primary key (P.IVA, Anno, Numero));

create table ESECUZIONE_CAMERIERE (
     Codice Fiscale Cameriere char(16) not null,
     Data Turno date not null,
      Ora Inizio Turno numeric(4,2) not null,
     Ora Fine Turno numeric(4,2) not null,
     constraint IDESECUZIONE_CAMERIERE primary key (Data Turno,  Ora Inizio Turno, Ora Fine Turno, Codice Fiscale Cameriere));

create table ESECUZIONE_CASSIERE (
     Codice Fiscale Cassiere char(16) not null,
     Data Turno date not null,
     Ora Inizio Turno numeric(4,2) not null,
     Ora Fine Turno numeric(4,2) not null,
     constraint IDESECUZIONE_CASSIERE primary key (Data Turno, Ora Inizio Turno, Ora Fine Turno, Codice Fiscale Cassiere));

create table ESECUZIONE_CUOCO (
     Data Turno date not null,
     Ora Inizio Turno numeric(4,2) not null,
     Ora Fine Turno numeric(4,2) not null,
     Codice Fiscale Cuoco char(16) not null,
     constraint IDESECUZIONE_CUOCO primary key (Data Turno, Ora Inizio Turno, Ora Fine Turno, Codice Fiscale Cuoco));

create table FATTURA (
     P.IVA varchar(11) not null,
     Anno numeric(4) not null,
     Numero numeric(5) not null,
     DDT_P.IVA varchar(11) not null,
     DDT_Anno char(4) not null,
     DDT_Numero char(3) not null,
     Importo Netto numeric(5) not null,
     IVA char(3) not null,
     Pagata char(2) not null,
     constraint IDFATTURA primary key (P.IVA, Anno, Numero),
     constraint FKSPESA_ORDINE_ID unique (DDT_P.IVA, DDT_Anno, DDT_Numero));

create table FORNITORE (
     P.IVA varchar(11) not null,
     Nome Azienda char(20) not null,
     Telefono numeric(11) not null,
     E-Mail char(20) not null,
     Stato char(10) not null,
     constraint IDFORNITORE primary key (P.IVA));

create table GRADIMENTO (
     Numero Tavolo char(2) not null,
     Data Prenotazione date not null,
     Ora Prenotazione numeric(4,2) not null,
     Importo Mancia numeric(5,2),
     Livello di Gradimento numeric(1),
     Codice Fiscale char(16) not null,
     constraint FKGRA_PRE_ID primary key (Numero Tavolo, Data Prenotazione, Ora Prenotazione));

create table INGREDIENTE (
     Codice char(10) not null,
     Nome char(15) not null,
     Scorta numeric(3) not null,
     Descrizione char(20) not null,
     constraint IDINGREDIENTE primary key (Codice));

create table ORDINABILE (
     Codice char(5) not null,
     Nome char(15) not null,
     Prezzo numeric(5,2) not null,
     Descrizione char(10) not null,
     Tipo char(10) not null,
     constraint IDORDINABILE_ID primary key (Codice));

create table ORDINAZIONE (
     Numero Tavolo numeric(2) not null,
     Data Prenotazione date not null,
     Ora Prenotazione numeric(4) not null,
     Codice Ordinabile char(10) not null,
     Quantità numeric(3) not null,
     constraint IDORDINAZIONE primary key (Codice Ordinabile, Numero Tavolo, Data Prenotazione, Ora Prenotazione));

create table ORDINE (
     Codice Ordine numeric(10) not null,
     Prezzo Unitario numeric(6,2) not null,
     Quantità numeric(2) not null,
     Data date not null,
     P.IVA char(11),
     Anno numeric(4),
     Numero numeric(4),
     Codice Ingrediente char(10) not null,
     Codice Fiscale char(16) not null,
     constraint IDDETTAGLIO_ORDINE primary key (Codice Ordine));

create table PAGAMENTO (
     Numero Tavolo numeric(2) not null,
     Data Prenotazione date not null,
     Ora Prenotazione numeric(4,2) not null,
     Data Scontrino date not null,
     Numero Scontrino numeric(3) not null,
     Metodo di Pagamento char(15) not null,
     constraint FKPAG_PRE_ID primary key (Numero Tavolo, Data Prenotazione, Ora Prenotazione),
     constraint FKPAG_SCO_ID unique (Data Scontrino, Numero Scontrino));

create table PRENOTAZIONE (
     Numero numeric(3) not null,
     Data date not null,
     Ora numeric(4) not null,
     Numero Persone numeric(3) not null,
     Numero di Telefono numeric(11) not null,
     constraint IDPRENOTAZIONE primary key (Numero, Data, Ora));

create table REALIZZAZIONE (
     Codice Ordinabile char(10) not null,
     Codice Ingrediente char(10) not null,
     constraint IDREALIZZAZIONE primary key (Codice Ingrediente, Codice Ordinabile));

create table SCONTRINO (
     Data date not null,
     Numero char(5) not null,
     Ora numeric(4,2) not null,
     Totale numeric(6,2) not null,
     Coperto numeric(4,2) not null,
     Codice Fiscale char(16) not null,
     constraint IDSCONTRINO_ID primary key (Data, Numero));

create table SERVIZIO (
     Numero Tavolo numeric(2) not null,
     Codice Fiscale Cameriere char(16) not null,
     Data Turno date not null,
     Ora Inizio Turno numeric(4,2) not null,
     Ora Fine Turno numeric(4,2) not null,
     constraint IDSERVIZIO primary key (Codice Fiscale Cameriere, Numero Tavolo, Data Turno, Ora Inizio Turno, Ora Fine Turno));

create table TAVOLO (
     Numero numeric(2) not null,
     Numero Posti numeric(3) not null,
     Descrizione char(10) not null,
     constraint IDTAVOLO primary key (Numero));

create table TURNO (
     Data date not null,
     Ora Inizio numeric(4,2) not null,
     Ora Fine numeric(4,2) not null,
     constraint IDTURNO primary key (Data, Ora Inizio, Ora Fine));


-- Constraints Section
-- ___________________ 

alter table CONTRATTO add constraint FKIMPIEGO_CUOCO
     foreign key (Cuoco_Codice Fiscale)
     references CUOCO;

alter table CONTRATTO add constraint FKIMPIEGO_CASSIERE
     foreign key (Cassiere_Codice Fiscale)
     references CASSIERE;

alter table CONTRATTO add constraint FKIMPIEGO_CAMERIERE
     foreign key (Cameriere_Codice Fiscale)
     references CAMERIERE;

alter table DDT add constraint FKINTESTAZIONE_DDT
     foreign key (P.IVA)
     references FORNITORE;

alter table ESECUZIONE_CAMERIERE add constraint FKESE_TUR
     foreign key (Data Turno,  Ora Inizio Turno, Ora Fine Turno)
     references TURNO;

alter table ESECUZIONE_CAMERIERE add constraint FKESE_CAM
     foreign key (Codice Fiscale Cameriere)
     references CAMERIERE;

alter table ESECUZIONE_CASSIERE add constraint FKESE_TUR
     foreign key (Data Turno, Ora Inizio Turno, Ora Fine Turno)
     references TURNO;

alter table ESECUZIONE_CASSIERE add constraint FKESE_CAS
     foreign key (Codice Fiscale Cassiere)
     references CASSIERE;

alter table ESECUZIONE_CUOCO add constraint FKESE_CUO
     foreign key (Codice Fiscale Cuoco)
     references CUOCO;

alter table ESECUZIONE_CUOCO add constraint FKESE_TUR
     foreign key (Data Turno, Ora Inizio Turno, Ora Fine Turno)
     references TURNO;

alter table FATTURA add constraint FKINTESTAZIONE_FATTURA
     foreign key (P.IVA)
     references FORNITORE;

alter table FATTURA add constraint FKSPESA_ORDINE_FK
     foreign key (DDT_P.IVA, DDT_Anno, DDT_Numero)
     references DDT;

alter table GRADIMENTO add constraint FKGRA_CAM
     foreign key (Codice Fiscale)
     references CAMERIERE;

alter table GRADIMENTO add constraint FKGRA_PRE_FK
     foreign key (Numero Tavolo, Data Prenotazione, Ora Prenotazione)
     references PRENOTAZIONE;

alter table ORDINAZIONE add constraint FKORD_ORD
     foreign key (Codice Ordinabile)
     references ORDINABILE;

alter table ORDINAZIONE add constraint FKORD_PRE
     foreign key (Numero Tavolo, Data Prenotazione, Ora Prenotazione)
     references PRENOTAZIONE;

alter table ORDINE add constraint FKCONSEGNA_FK
     foreign key (P.IVA, Anno, Numero)
     references DDT;

alter table ORDINE add constraint FKCOMPOSIZIONE
     foreign key (Codice Ingrediente)
     references INGREDIENTE;

alter table ORDINE add constraint FKCOMMISSIONARE
     foreign key (Codice Fiscale)
     references CUOCO;

alter table PAGAMENTO add constraint FKPAG_PRE_FK
     foreign key (Numero Tavolo, Data Prenotazione, Ora Prenotazione)
     references PRENOTAZIONE;

alter table PAGAMENTO add constraint FKPAG_SCO_FK
     foreign key (Data Scontrino, Numero Scontrino)
     references SCONTRINO;

alter table PRENOTAZIONE add constraint FKOCCUPAZIONE
     foreign key (Numero)
     references TAVOLO;

alter table PRENOTAZIONE add constraint FKRICHIESTA
     foreign key (Numero di Telefono)
     references CLIENTE;

alter table REALIZZAZIONE add constraint FKREA_ING
     foreign key (Codice Ingrediente)
     references INGREDIENTE;

alter table REALIZZAZIONE add constraint FKREA_ORD
     foreign key (Codice Ordinabile)
     references ORDINABILE;

alter table SCONTRINO add constraint FKEMISSIONE_SCONTRINO
     foreign key (Codice Fiscale)
     references CASSIERE;

alter table SERVIZIO add constraint FKSER_TUR
     foreign key (Data Turno, Ora Inizio Turno, Ora Fine Turno)
     references TURNO;

alter table SERVIZIO add constraint FKSER_CAM
     foreign key (Codice Fiscale Cameriere)
     references CAMERIERE;

alter table SERVIZIO add constraint FKSER_TAV
     foreign key (Numero Tavolo)
     references TAVOLO;

