<?php
namespace App\Controller;
use App\Entity\Game;

class GameController{
    
    function create($data=null){
        return json_encode(["name"=> "Create - ", "data"=>$data]);
    }    

    function update($id, $data=null){
        return json_encode(["name"=> "update- {$id}", "data"=>$data]);
    } 

    function delete($id){
        return json_encode(["name"=> "delete- {$id}"]);
    } 

    function getById($id=0){
        return json_encode(["name"=> "getById - {$id}"]);
    }  

    function getAll(){
        return json_encode(["name"=> "getAll"]);
    }   

}

?>