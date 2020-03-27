#include <stdio.h>
#include <string.h>
#include <mysql.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <unistd.h>
#include <sys/types.h>
#include <ctype.h>

int main(int argc, char *argv[]) {
	
	//Variables
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	char peticio [512];
	char resposta [512];
	
	//obrir el socket
	if((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creant el socket");
	
	//Incialoitzem a zero el serv_adr
	memset(&serv_adr,0,sizeof(serv_adr));
	serv_adr.sin_family = AF_INET;
	
	//Associem el socket a una màquina
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	
	//Definim el port
	serv_adr.sin_port = htons(9070);
	
	//Fem el bind i l'escolta
	if (bind(sock_listen, (struct sockaddr * ) & serv_adr,sizeof(serv_adr)) < 0)
		printf("Error al bind");
	if (listen(sock_listen, 3) < 0)
		printf("Error en el listen");
	
	//Comencem amb el bucle de la temperatura
	for(;;)
	{
		printf("Escoltant\n");
		
		//Detecta la connexió
		sock_conn = accept (sock_listen, NULL, NULL);
		printf("Ha rebut la connexio\n");
		
		//Bucle d'atenció al client
		int acabar = 0;
		while (!acabar)
		{
			//Rep el senyal
			ret = read (sock_conn, peticio, sizeof(peticio));
			printf("Rebut\n");
			peticio[ret] = '\0';
			printf("Petició: %s \n", peticio);
			
			//Procesa el missatge
			char *p = strtok(peticio,"/");
			int tempDesti = atoi (p);
			
			if (tempDesti == 0)
				acabar = 1;
			else
			{
				//Procesa la resta de parts
				p = strtok(NULL,"/");
				int tempInici = atoi(p);
				p = strtok(NULL,"/");
				float tempVal = atof(p);
				
				if (tempDesti == 1) //A Celsius
				{
					if (tempInici == 1) //De Celsius
					{
						float Celsius = tempVal;
						sprintf(resposta, "%f C", Celsius);
					}
					else if (tempInici == 2) //De Kelvin
					{
						float Celsius = tempVal - 273.15;
						sprintf(resposta, "%f C", Celsius);
					}
					else if (tempInici == 3) //De Farehneit
					{
						float Celsius = (tempVal - 32)*(5/9);
						sprintf(resposta, "%f C", Celsius);
					}
					else //De Rankine
					{
						float Celsius = (tempVal - 491.67)*(5/9);
						sprintf(resposta, "%f C", Celsius);
					}
					
				}
				else if (tempDesti == 2) //A Kelvin
				{
					if (tempInici == 1) //De Celsius
					{
						float Kelvin = tempVal + 273.15;
						sprintf(resposta, "%f K", Kelvin);
					}
					else if (tempInici == 2) //De Kelvin
					{
						float Kelvin = tempVal;
						sprintf(resposta, "%f K", Kelvin);
					}
					else if (tempInici == 3) //De Farehneit
					{
						float Kelvin = (tempVal + 459.67)*(5/9);
						sprintf(resposta, "%f K", Kelvin);
					}
					else if (tempInici == 4) //De Rankine
					{
						float Kelvin = tempVal*(5/9);
						sprintf(resposta, "%f K", Kelvin);
					}
					
				}
				else if (tempDesti == 3) //A Farehneit
				{
					if (tempInici == 1) //De Celsius
					{
						float Fahrenheit = tempVal*(9/5) + 32;
						sprintf(resposta, "%f F", Fahrenheit);
					}
					else if (tempInici == 2) //De Kelvin
					{
						float Fahrenheit = tempVal*(9/5) - 459.67;
						sprintf(resposta, "%f F", Fahrenheit);
					}
					else if (tempInici == 3) //De Farehneit
					{
						float Fahrenheit = tempVal;
						sprintf(resposta, "%f F", Fahrenheit);
					}
					else if (tempInici == 4) //De Rankine
					{
						float Fahrenheit = tempVal - 459.67;
						sprintf(resposta, "%f F", Fahrenheit);
					}
					
				}
				else if (tempDesti == 4) //A Rankine
				{
					if (tempInici == 1) //De Celsius
					{
						float Rankine = (tempVal + 273.15)*(9/5);
						sprintf(resposta, "%f Ra", Rankine);
					}
					else if (tempInici == 2) //De Kelvin
					{
						float Rankine = tempVal*(9/5);
						sprintf(resposta, "%f Ra", Rankine);
					}
					else if (tempInici == 3) //De Farehneit
					{
						float Rankine = tempVal + 459.67;
						sprintf(resposta, "%f Ra", Rankine);
					}
					else if (tempInici == 4) //De Rankine
					{
						float Rankine = tempVal;
						sprintf(resposta, "%f Ra", Rankine);
					}

				}
				
				
				printf("Resposta: %s \n",resposta);
				//Envia la resposta
				write (sock_conn, resposta, strlen(resposta));
			}
			
		}
	}
	
	//Tanca la connexió
	close (sock_conn);
}

