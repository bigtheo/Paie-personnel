drop database if exists paieDb;
create database paieDb;
use paieDb;
create table users(id int unsigned not null auto_increment primary key,
					name varchar(50) not null,
                    password varchar(50) not null,
                    unique(name, password)
                    );

create table mois(id smallint unsigned auto_increment primary key,
				intitule enum('janvier','février','mars','avril','mai','juin','juillet','aout','septembre','octobre','novembre','decembre'),
                annee int unsigned not null check(annee>2020)
                );

create table personnel(id int unsigned not null auto_increment primary key,
						noms varchar(75) not null,
                        fonction enum('institutrice','enseignant','professeur','DE','DD','Prefet','menagère','Garde'),
                        adresse varchar(50),
                        telephone varchar(15),
                        section enum('primaire','secondaire','Maternelle')
                        );
                        
create table avantages(id int unsigned not null auto_increment primary key
						,salBrut dec not null
                        ,transport dec not null default 0
                        ,logement  decimal not null default 0
                        ,personnel_id int unsigned not null,
                        foreign key(personnel_id) references personnel(id)
                        );
					
create table primes(id int unsigned not null auto_increment primary key,
					assidite decimal not null default 0,
                    diplome decimal not null default 0,
                    fonction decimal not null default 0,
                    personnel_id int unsigned not null,
                    foreign key(personnel_id) references personnel(id)
                    );
                    
create table avances(id bigint unsigned not null auto_increment primary key,
					date_paie datetime default current_timestamp,
                    montant decimal not null check (montant>0),
                    personnel_id int unsigned not null, 
                    user_id int unsigned not null null,
                    mois_id smallint unsigned not null,
                    foreign key(personnel_id) references personnel(id),
                    foreign key(user_id) references users(id),
                    foreign key(mois_id) references mois(id)
                    );
create table retenus(id int unsigned not null auto_increment primary key,
					frais_scolaire decimal not null default 0,
                    inss decimal not null default 0,
                    ipr decimal not null default 0,
                    personnel_id int unsigned not null,
                    foreign key(personnel_id) references personnel(id)
                    );
create table paiement(id bigint unsigned not null primary key,
					date_paie datetime default current_timestamp,
                    personnel_id int unsigned not null,
                    mois_id smallint unsigned not null,
                    user_id int unsigned not null,
                    foreign key(personnel_id) references personnel(id),
                    foreign key(user_id) references users(id),
                    foreign key(mois_id) references mois(id)
                    );
