<?php

require_once 'lib/nusoap.php';
$cliente = new nusoap_client("http://localhost:8080/Clientews/Soap.php?wsdl");

$rut = "";
$respuestarut = $cliente->call("RutValidacion",array("rut"=>$rut));
if(empty($respuestarut))
    echo $respuestarut;
else
    echo $respuestarut;

$Apellido_p="";
$Apellido_m="";
$Nombres="";
$Genero="";

$parametros=array("Ap_A"=>$Apellido_p,"Ap_M"=>$Apellido_m,"Nombres"=>$Nombres,"Genero"=>$Genero);

$respuestamensaje = $cliente->call("Mensaje",$parametros);
if(empty($respuestamensaje))
    echo $respuestamensaje;
else
    echo $respuestamensaje;

?>