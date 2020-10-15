<?php

require_once 'lib/nusoap.php';
$cliente = new nusoap_client("http://localhost:8080/Clientews/Soap.php?wsdl");

$rut = "";
$respuestarut = $cliente->call("RutValidacion",array("rut"=>$rut));
if(empty($respuestarut))
    echo $respuestarut;
else
    echo $respuestarut;

$parametros=["silva","escala","marcelo alberto","m"];
$respuestamensaje = $cliente->call("Mensaje",array("Ap_A"=>$parametros,"Ap_M"=>$parametros,"Nombres"=>$parametros,"Genero"=>$parametros));
if(empty($respuestamensaje))
    echo $respuestamensaje;
else
    echo $respuestamensaje;

?>