<?php
    
    

    //Header
    header("Access-Control-Allow-Origin: *");
    header("Content-Type: application/json;charset=UTF-8");
    header("Access-Control-Allow-Methods: GET, POST, PUT, DELETE");
    header("Access-Control-Max-Age: 3500");
    header("Access-Control-Allow-Headers: Content-Type, Access-Control-Allow-Headers, Autorization, X-Requested-With");
    //Header

    require_once("../../vendor/autoload.php");
    use App\Controller\GameController;


    $controller = null;
    $id = null;
    $data = null;
    $method = $_SERVER["REQUEST_METHOD"];
    $uri=$_SERVER["REQUEST_URI"];
    $unsetCount = 2;

     //trata Dados do Form
    parse_str(file_get_contents('php://input'),$data);

    //TrataUri
    $ex = explode("/", $uri);
    var_dump($ex); // esse mano mostra

    for ($i = 0; $i <= $unsetCount; $i++)
    {
    	unset($ex[$i]);
    }
    $ex = array_filter(array_values($ex));
    var_dump($ex);

    if (isset($ex[0]))
    {
    	$controller = $ex[0];
    }
    
    if (isset($ex[1]))
    {
    	$id = $ex[1];
    }

    echo json_encode(["tipo" =>$method, "data"=>$data, "uri"=>$uri,"controller"=>$controller,"id"=>$id ] );
    /*
    $gameController = new GameController();
 
    switch ($method)
    {
        case 'GET':
            if ($controller!=null &&$id==null)
            {
            	echo $gameController->getAll();
            }
            elseif ($controller!=null &&$id!=null)
            {
            	echo $gameController->getById($id);
            }
            else{
                echo json_encode(["result"=>"invalid"]);
            }
            break;
        case 'POST':
            if ($controller!=null &&$id==null)
            {
            	echo $gameController->create($data);
            }            
            else{
                echo json_encode(["result"=>"invalid"]);
            }
            break;
        case 'PUT':
            if ($controller!=null &&$id!=null)
            {
            	echo $gameController->update($id, $data);
            }            
            else{
                echo json_encode(["result"=>"invalid"]);
            }
            break;
        case 'DELETE':
            if ($controller!=null &&$id!=null)
            {
            	echo $gameController->delete($id);
            }            
            else{
                echo json_encode(["result"=>"invalid"]);
            }
            break;
    	default:
             echo json_encode(["result"=>"invalid request"]);
             break;
    }
  */      
?>