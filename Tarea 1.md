##Tarea 1

####1.    Investigar las diferencias que hay entre C/C++/C#, indicar al menos 5 de cada lenguaje.

Comenzando por un poco de la historia entre estos lenguajes tenemos que el primero de ellos fue **C** creado en los laboratorios Bell y es el sucesor del lenguaje B (de Bell).

C es un lenguaje de Bajo nivel que se encuentra en un punto en que por debajo de él existe Ensamblador para comunicarse con el hardware y por encima de el existen lenguajes interpretados y/o ejecutados en Maquinas Virtuales como Java Ruby JavaScript Python.

Tanto C y C++ en su estructura cuentan con archivos de tipo código(.c y .cpp) y cabecera(.h).
Ambos son Lenguajes para código estructurado sin embargo C++ implementa además de estructurado, el lenguaje Orientado a Objetos o POO.

Ambos lenguajes cuentan con la opción de interactuar directamente con la memoria RAM con allocaciones de memoria, además pueden trabajar en conjunto con el Sistema Operativo de elección sea OSx, Win, Unix o Linux para crear a bajo nivel hilos de ejecución.

Existen bastantes semejanzas entre C y C++, C# por otro lado al basarse en estos y haber nacido con el objetivo de ser utilizado para Diseño Orientado a Eventos (*Event Driven Develpment*) de Forms de Microsoft es como una colección de C y C++ pero más moderno y fácil de utilizar en cuanto a memoria RAM; por tanto esta pregunta la responderé enfocándome en las semejanzas de C y C++ y luego los compararé con C#.

1.    Diferencias entre C, C++ y C# en cuanto a su creación:
    -    C fue creado en Laboratorios Bell en 1972.
    -    C++ fue creado en 1983 casi 2 décadas después por Bjarne Stroustrup.
    -    C# es un conjunto de estos 2 anteriores creado por Microsoft en el 2000.

2.    Diferencias entre C, C++ y C# en cuanto al Paradigma:
    -    C es un lenguaje Imperativo estructurado
    -    C++ es multi paradigma: funcional procedural, genérico y Orientado a Objetos.
    -    C# entre los 3 C# es un conjunto de los paradigmas anteriores, es estructurado, imperativo, Orientado a Objetos, Orientado a Eventos, Orientado a Procesos, Funcional, Genérico, reflectivo y concurrente.

3.    Diferencias entre C, C++ y C# en cuanto a su estructura:
    -    Tanto C y C++ se leen de arriba a abajo ya que son estructurales, por tanto todo elemento utilizado en el método main() debe haber sido antes creado ya sea en un header o al inicio del código, structs en C u objetos en C++ métodos y demás todo esto requiere un *Fordward Declaration*(Una declaración temprana).
    -    Mientras que por el lado de C#, este lenguaje permite la creación de métodos sin necesidad de *fordward declaration* y también puede agrupar funcionabilidad en archivos .DLL, cosas como acceso a una Base de Datos todos los métodos fijos se pueden guardar en un DLL para reducir la sobrecarga en ejecución, al crear más objetos de los necesarios.

4.    Diferencias en cuanto a Estructuras.
    -    En C no existen objetos pero se puede emular haciendo uso de structs.
    -    C++ ya implementa el uso de Objetos para así mejorar la abstracción de objetos por clases, clase abstracta, herencia, *interface* entre otros.
    -    C# Puede usar tanto estructs como Objetos, al igual que otras estructuras más avanzadas como Listas Enlazadas, Array List, Hashmap, stack entre otros.

5.    Diferencias en cuanto a Variables.
    -    Tanto C y C++ hacen uso de Punteros(variables que se guardan en el modo par "espacio en memoria":"contenido")
    -    C# también puede hacer uso de punteros pero no es para lo que se creó el lenguaje.
    -    C no tiene variables del tipo String por que son objetos y C no hace uso de Objetos, C++ fué cuando ya se implementó una clase String.
    -    C# contiene variables bastante complejas para el manejo de Redes, conexiones a Bases de Datos, Hashes como SHA1 CRC entre otros; y acá es donde se ve el enfoque a Web y forms de éste lenguaje comparado a C que se inventó como una versión portable de Ensamblador y C++ como una extensión de C que no fuese tan estática y pudiera hacer uso de Abstracción para reutilización de código con Objetos.

6.    Diferencias según el Compilador.
    -    C tiene como compiladores: GCC, Clang, Linux C, Mac C, Small-C, visual C++ y Ritchie C Compiler  entre otros.
    -    C++ tiene como compiladores: G++, GCC, Clang, Solaris Studio, Visual C++, CINT y C++ Builder entre otros.
    -    C# tiene como compiladores: Visual C# (Express y no express), mono, SharpDevelp, Roslyn y  Portable.NET.

Además de esas diferencias antes mencionadas existen otras pero también cabe destacar que existen muchas coincidencias entre estos lenguajes por que vinieron en el orden C, C++ y C# , uno basándose en lenguajes anteriores, pero queriendo innovar en áreas que el anterior dejó sin explorar y con un nuevo punto de vista y objetivo.

---

####2. Investigar la herramienta Git y Github, indicar que son como se usan y sus principales comandos

####Git:

Git es un sistema de control de versiones para manejar el historial del código, cambios realizados, sugerencias, comentarios a cambios que fue creado por Linux Torvalds y Junio Hamano entre otros, con su primer release en el año 2005, escrito en C, Shell, Perl, Tcl y Python, funciona en múltiples plataformas como Linux, POSIX, Windows y OSx.

Su desarrollo se inicia cuando existieron problemas con BitKeeper una herramienta de control de versiones que, al existir problemas legales con Bit Keeper Linux Torvalds decide crear su propia versión de manejo de paquetes.

Por otro lado.

####Github:

Github es una empresa que tomó el sistema de git y creó su propia implementación basándose en Git y dándole gran cantidad de valor agregado al software Git, al tener una interfaz gráfica, control por grupos que obtienen acceso al código y demás opciones para mejorar el acceso a Git como herramienta de uso cotidiano para programadores.

###Comandos más utilizados con MAN

Inicializa o reinicializa un repositorio vacío.

    git init


Muestra que archivos estan ciendo trackeados y cuales no.

    git status


Agrega el archivo al los cambios

    git add *filename* 


Crea un nuevo commit con los cambios y un mensaje

    git commit -m "message "


Agrega todos los archivos tipo asterisco

    git add '*.txt'


Ver todo el log de commits en la forma 

    git log


	commit 3852b4db1634463d0bb4d267edb7b3f9cd02ace1
	Author: Try Git <try_git@github.com>
	Date: Sat Oct 10 08:30:00 2020 -0500
	
	Add all the octocat txt files
	
	commit b652edfd888cd3d5e7fcb857d0dabc5a0fcb5e28
	Author: Try Git <try_git@github.com>
	Date: Sat Oct 10 08:30:00 2020 -0500


Agrega remotamente con origen URL destino

    git remote add origin https://github.com/try-git/try_git.git



Hace el Push de los cambios realizados a el origen 	antes especificado en URL

    git push -u origin master


> The -u tells Git to remember the parameters, so that next time we can simply run git push and Git will know what to do.

Cuando hemos compartido el proyecto y varias personas han hecho sus propios commits con este comando llamamos la versión modificada con todos los cambios aplicados.

    git pull origin master


Para averiguar que está diferente desde el ultimo commit
    git diff HEAD


Se ve algo así 

	diff --git a/octocat.txt b/octocat.txt
	index 7d8d808..e725ef6 100644
	--- a/octocat.txt
	+++ b/octocat.txt
	@@ -1 +1 @@
	-A Tale of Two Octocats
	+[mA Tale of Two Octocats and an Octodog

#####CONCEPTO Staged Files son archivos que se le dijo a Git que vana ser commited pero todavía no se han posteado.

Muestra la diferencia entre lo que esta staged y 

    git diff --staged

Reset archivos / o unstage archivos con el comando reset

    git reset octofamily/octodog.txt

Devolverse a como el archivo era antes

    git checkout -- octocat.txt



#####CONCEPTO Branch, version separada que solo una persona puede ver, cuando terminan pueden hacer un Merge y mezclar las 2 versiones.

	git branch clean_up


Ahora se ven los branches que han sido creados: Ahora se esta en 'clean_up'

    git checkout clean_up


Estando en el Branch que se llama clea_up se puede eliminar todos los .txt 

    git rm '*.txt'

	
	rm 'blue_octocat.txt'
	rm 'octocat.txt'
	rm 'octofamily/baby_octocat.txt'
	rm 'octofamily/momma_octocat.txt'
	rm 'red_octocat.txt'

	git commit -m "Remove all the cats"

Remover todos los archivos en un nuevo commit

	//RESULTADO
	[clean_up 63540fe] Remove all the cats
	5 files changed, 5 deletions(-)
	delete mode 100644 blue_octocat.txt
	delete mode 100644 octocat.txt
	delete mode 100644 octofamily/baby_octocat.txt
	delete mode 100644 octofamily/momma_octocat.txt
	delete mode 100644 red_octocat.txt

Ahora nos movemos de vuelta a master para poder hacer el merge de cambios

	git checkout master

#####Mostrar todos los branches con *$git show-branch* 

Ahora para hacer un merge limpiando

	git merge clean_up 


Delete a branch 

	git branch -d clean_up

Ahora enviamos todo al repositorio

	git branch -d clean_up

---

####Lista de comandos:
 
Setup and Config

    config
    help

Getting and Creating Projects

    init
    clone

Basic Snapshotting

    add
    status
    diff
    commit
    reset
    rm
    mv

Branching and Merging

    branch
    checkout
    merge
    mergetool
    log
    stash
    tag

Sharing and Updating Projects

    fetch
    pull
    push
    remote
    submodule

Inspection and Comparison

    show
    log
    diff
    shortlog
    describe

Patching

    apply
    cherry-pick
    diff
    rebase
    revert

Debugging

    bisect
    blame
    grep

Email

    am
    apply
    format-patch
    send-email
    request-pull

External Systems

    svn
    fast-import

Administration

    clean
    gc
    fsck
    reflog
    filter-branch
    instaweb
    archive
    bundle

Server Admin

    daemon
    update-server-info

Plumbing Commands

    cat-file
    commit-tree
    count-objects
    diff-index
    for-each-ref
    hash-object
    ls-files
    merge-base
    read-tree
    rev-list
    rev-parse
    show-ref
    symbolic-ref
    update-index
    update-ref
    verify-pack
    write-tree


![Some Examples](https://raw.githubusercontent.com/RolandoED/Tarea1/master/Images/Git1.png)

![Some Examples](https://raw.githubusercontent.com/RolandoED/Tarea1/master/Images/Git2.png)

###LINKS DE INTERES

Intro en 15 min

[https://try.github.io/levels/1/challenges/1](https://try.github.io/levels/1/challenges/1 "https://try.github.io/levels/1/challenges/1")

Cheat Sheet

[http://ndpsoftware.com/git-cheatsheet.html]("http://ndpsoftware.com/git-cheatsheet.html")

Git the simple Guide 

[http://rogerdudler.github.io/git-guide/](http://rogerdudler.github.io/git-guide/ "http://rogerdudler.github.io/git-guide/")

Pro Git Book

[https://git-scm.com/book/en/v2](https://git-scm.com/book/en/v2 "https://git-scm.com/book/en/v2")

Another Cheat Sheet 

[http://overapi.com/git](http://overapi.com/git "http://overapi.com/git")