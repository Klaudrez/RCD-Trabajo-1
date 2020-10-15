<?php
require_once('lib/nusoap.php');
$servicio = new nusoap_server();

$servicio->configureWSDL("Soap","urn:Soap.php?wsdl");

function RutValidacion($rut)
{
    if($rut!=NULL && $rut!="")
    {
        $cortar = substr($rut,0,(strlen($rut)-2));
        $digito = substr($rut,-1);

        if(ValidarNumero($cortar))
        {
            if(Mayus($digito)==AlgoritmoRut($cortar))
                return "Rut valido. ";
            else
                return "Rut no valido. ";
        }
        else
            return "Formato no valido. ";
    }
    else
        return "Ingrese un rut valido. ";
}

function Mensaje($Ap,$Am,$N,$G)
{
    $respuesta="";

    if($Ap!=NULL && $Ap!="" && $Am!=NULL && $Am!="" && $N!=NULL && $N!="" && $G!=NULL && $G!="")
    {
        
        if(ValidarLetras($Ap) && ValidarLetras($Am) && ValidarLetras($N) && ValidarLetras($G))
        {
            if(Mayus($G)=="M")
                $respuesta = $respuesta."Sr. "; 
            else
            {   
                if(Mayus($G)=="F")
                    $respuesta = $respuesta."Sra. ";
                else
                    return "Ingrese un genero valido";
            }
            
            $respuesta = $respuesta.Mayus($N)." ".Mayus($Ap)." ".Mayus($Am);
            return $respuesta;

        }
        else
            return "Ingrese un nombre valido";
    }
    else
        return "Ingrese un nombre valido";
}

function ValidarLetras($palabra)
{
    $nombre1 = explode(" ",$palabra);
    foreach($nombre1 as $p)
    {
        if(!ctype_alpha($p))
            return false;
    }
    return true;
}

function AlgoritmoRut($r){
    $Digito;
    $Contador;
    $Multiplo;
    $Acumulador;
    $Digito_V;

    $Contador = 2;
    $Acumulador = 0;

    while ($r != 0)
    {
        $Multiplo = ($r % 10) * $Contador;
        $Acumulador = $Acumulador + $Multiplo;
        $r = $r / 10;
        $Contador = $Contador + 1;
        if ($Contador == 8)
        {
           $Contador = 2;
        }
    }

    $Digito = 11 - ($Acumulador % 11);
    $Digito_V = strval($Digito);
    if ($Digito == 10)
    {
        $Digito_V = "K";
    }
    if ($Digito == 11)
    {
        $Digito_V = "0";
    }
    return $Digito_V;

 }

function ValidarNumero($algo)
{
    if(!is_numeric($algo))
        return false;
    else
        return true;
}

function Mayus($phrase)
{
    $minuscula = strtolower($phrase);
    $phrase = ucwords($minuscula);

    return $phrase;
}


$servicio->register("RutValidacion",array("rut"=>"xsd:string"),array("return"=>"xsd:string"),"urn:Soap.php?wsdl");

$servicio->register("Mensaje",array("Ap"=>"xsd:string","Am"=>"xsd:string","N"=>"xsd:string","G"=>"xsd:string"),array("return"=>"xsd:string"),"urn:Soap.php?wsdl");

@$servicio->service(file_get_contents("php://input"));
?>