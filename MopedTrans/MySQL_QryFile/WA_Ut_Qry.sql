
use drawmaindb;

show tables;
use drawtrandb;

delimiter $$

CREATE TABLE `film` (
  `film_id` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
  `title` varchar(255) NOT NULL,
  `description` text,
  `release_year` year(4) DEFAULT NULL,
  `language_id` tinyint(3) unsigned NOT NULL,
  `original_language_id` tinyint(3) unsigned DEFAULT NULL,
  `rental_duration` tinyint(3) unsigned NOT NULL DEFAULT '3',
  `rental_rate` decimal(4,2) NOT NULL DEFAULT '4.99',
  `length` smallint(5) unsigned DEFAULT NULL,
  `replacement_cost` decimal(5,2) NOT NULL DEFAULT '19.99',
  `rating` enum('G','PG','PG-13','R','NC-17') DEFAULT 'G',
  `special_features` set('Trailers','Commentaries','Deleted Scenes','Behind the Scenes') DEFAULT NULL,
  `last_update` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`film_id`),
  KEY `idx_title` (`title`),
  KEY `idx_fk_language_id` (`language_id`),
  KEY `idx_fk_original_language_id` (`original_language_id`),
  CONSTRAINT `fk_film_language` FOREIGN KEY (`language_id`) REFERENCES `language` (`language_id`) ON UPDATE CASCADE,
  CONSTRAINT `fk_film_language_original` FOREIGN KEY (`original_language_id`) REFERENCES `language` (`language_id`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=1001 DEFAULT CHARSET=utf8$$

CREATE
DEFINER=`root`@`localhost`
TRIGGER `sakila`.`ins_film`
AFTER INSERT ON `sakila`.`film`
FOR EACH ROW
BEGIN
    INSERT INTO film_text (film_id, title, description)
        VALUES (new.film_id, new.title, new.description);
  END
$$

CREATE
DEFINER=`root`@`localhost`
TRIGGER `sakila`.`upd_film`
AFTER UPDATE ON `sakila`.`film`
FOR EACH ROW
BEGIN
    IF (old.title != new.title) or (old.description != new.description)
    THEN
        UPDATE film_text
            SET title=new.title,
                description=new.description,
                film_id=new.film_id
        WHERE film_id=old.film_id;
    END IF;
  END
$$

CREATE
DEFINER=`root`@`localhost`
TRIGGER `sakila`.`del_film`
AFTER DELETE ON `sakila`.`film`
FOR EACH ROW
BEGIN
    DELETE FROM film_text WHERE film_id = old.film_id;
  END
$$

