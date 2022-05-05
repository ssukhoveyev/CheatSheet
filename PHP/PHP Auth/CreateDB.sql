CREATE TABLE `users` ( <br>
`user_id` int(11) unsigned NOT NULL auto_increment, <br>
`user_login` varchar(30) NOT NULL, <br>
`user_password` varchar(32) NOT NULL, <br>
`user_hash` varchar(32) NOT NULL, <br>
`user_ip` int(10) unsigned NOT NULL default '0', <br>
PRIMARY KEY (`user_id`) <br>
) ENGINE=MyISAM DEFAULT CHARSET=cp1251 AUTO_INCREMENT=1 ;