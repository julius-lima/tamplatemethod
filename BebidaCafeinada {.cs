public abstract class BebidaCafeinada {

    public final void preparar(){ /* O TEMPLATE METHOD */

        esquentarAgua();
        mistura();
        colocarEmCopo();
        addCondimentos();
    }

    public void esquentarAgua(){

        System.out.println( "Esquentando água" );
    }

    public abstract void mistura();

    public void colocarEmCopo(){

        System.out.println( "Colocando no copo" );
    }

    public abstract void addCondimentos();
}


public class Cafe extends BebidaCafeinada {

    @Override
    public void mistura(){

        System.out.println( "Moendo café" );
    }

    @Override
    public void addCondimentos(){

        System.out.println( "Adicionando açúcar e leite" );
    }
}

public class Cha extends BebidaCafeinada {

    @Override
    public void mistura(){

        System.out.println( "Preparando o saquinho de chá" );
    }

    @Override
    public void addCondimentos(){

        System.out.println( "Adicionando algumas gotas de limão" );
    }
}