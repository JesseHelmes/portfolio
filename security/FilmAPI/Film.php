<?php
class Film{

	//dit zorgte ervoor dat ik geen gegevens kon zien
	//private $id, $title, $speelduur, $kijkwijzer, $genre;

	/*public function __construct($id, $titel, $speelduur, $kijkwijzer, $genre){
		$this->id = $id;
		$this->titel = $titel;
		$this->speelduur = $speelduur;
		$this->kijkwijzer = $kijkwijzer;
		$this->genre = $genre;
	}*/

	//getters
	public function getId(){
		return $this->id;
	}

	public function getTitel(){
		return $this->titel;
	}

	public function getSpeelduur(){
		return $this->speelduur;
	}

	public function getKijkwijzer(){
		return $this->kijkwijzer;
	}

	public function getGenre(){
		return $this->genre;
	}

	//setters
	public function setId($id){
		$this->id = $id;
	}

	public function setTitel($titel){
		$this->titel = $titel;
	}

	public function setSpeelduur($speelduur){
		$this->speelduur = $speelduur;
	}

	public function setKijkwijzer($kijkwijzer){
		$this->kijkwijzer = $kijkwijzer;
	}

	public function setGenre($genre){
		$this->genre = $genre;
	}
}
?>