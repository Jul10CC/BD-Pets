   M S B A M L   `   `   `  ����=  9UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:UI.MantenimientosUI.Mantenimientos  5      *    $UI.Mantenimientos.UserControlCliente   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:UI.Mantenimientos     5      U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      � ���#FFFAF9$
��Left=�6!   $��Stretch=�6<   .+�5   
   �� $
��Left=�6   $	��165��6/   $��	11,10,0,0q�6<   
���   �$	��Top=�6^   $	��679��6v   �� 5   
   -   5          ��Name$  labelId��5      $��Cliente ID:��6!   $
��Left=�67   $��	22,10,0,0q�6R   $	��Top=�6e   ���#8F2A16$
��Bold"�6�   $��Tahoma)�6�    J� RenderTransformOrigin$ 1.901,0.775&�6�   �� 5   
   -   5         ��Name$ TextClienteId��5   %   {�.  $��0��6<   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ codigo��6I   $��30��6q   $��117,4,452.6,466q�6}   ��6�   �� *SelectedItem.ClienteID+ �� ElementName$ 	dataGrid1�� �� Mode$ OneWay=��� 5   
   -   5        $  labelNit��5      $
��NIT:��6"   $
��Left=�61   $��
22,134,0,0q�6L   $	��Top=�6`   ���#8F2A16$
��Bold"�6�   $��Tahoma)�6�   $ -0.062,-0.725&�6�   �� 5   
   -   5        $ 
TextNombre��5      $��1��6&   $ nombre��63   $��30��6[   $��117,41,452.6,429q�6g   ��6�   �� *SelectedItem.Nombre+$ 	dataGrid1��$ OneWay=�6�   �� 5   
   -   5        $  
labeNombre��5      $��Nombre:��6$   $
��Left=�66   $��	22,46,0,0q�6Q   $	��Top=�6d   ���#8F2A16$
��Bold"�6�   $��Tahoma)�6�   �� 5   
   -   5        $ TextNit��5      $��3��6#   $	 nit��60   $��30��6U   $��117,128,429.6,342q�6a   ��6|   �� *SelectedItem.NIT+$ 	dataGrid1��$ OneWay=��� 5   
   -   5        $  labelApellido��5      $��	Apellido:��6'   $
��Left=�6;   $��	22,94,0,0q�6V   $	��Top=�6i   ���#8F2A16$
��Bold"�6�   $��Tahoma)�6�   �� 5   
   -   5        $ TextApellido��5      $��2��6(   $ apellido��65   $��30��6_   $��117,89,452.6,381q�6k   ��6�   �� *SelectedItem.Apellido+$ 	dataGrid1��$ OneWay=��� 5   
   -	   5        $  labelDireccion��5      $��Dirección:��6(   $
��Left=�6=   $��
408,27,0,0q�6X   $	��Top=�6l   ���#8F2A16$
��Bold"�6�   $��Tahoma)�6�   $ 0.509,-1.579&�6�   �� 5   
   -
   5        $ TextDireccion��5      $��4��6)   $ 	direccion��66   $��30��6a   $��515,21,35.6,449q�6m   ��6�   �� *SelectedItem.Direccion+$ 	dataGrid1��$ OneWay=��� 5   
   -   5        $  	labelTel1��5      $��Teléfono 1:��6#   $
��Left=�69   $��
408,69,0,0q�6T   $	��Top=�6h   ���#8F2A16$
��Bold"�6�   $��Tahoma)�6�   �� 5   
   -   5        $ TextTel1��5      $��5��6$   $ teléfono 1��61   $��30��6]   $��515,63,31.6,407q�6i   ��6�   �� *SelectedItem.Telefono1+$ 	dataGrid1��$ OneWay=��� 5   
   -   5         ��Name$ buttonAgregar��5      ���#FF9557$��Agregar��6=   $
��Left=�6O   $��
11,196,0,0q�6j   $	��Top=�6~   $	��150��6�   $ -0.053,0&�6�   $��35��6�   ���#FFFFFF$
��Bold"�6�   ���#ffff006  �� 5   
   -   5        $ buttonGrabar��5      ���#EE8813$��Grabar��6<   $
��Left=�6M   $��
11,196,0,0q�6h   $	��Top=�6|   $	��150��6�   $ -0.053,0&�6�   $��35��6�   ���	#FF0C0A0A$
��Bold"�6�   ���#000000$y�Hidden=�6  6   �� 5   
   -   5        $ buttonEditar��5      ���#C26C1B$��Editar��6<   $
��Left=�6M   $��180,196,0,0q�6h   $	��Top=�6}   $	��150��6�   $ -0.053,0&�6�   $��35��6�   
���   ����#000000{�.  6	  �� 5   
   -   5        $ buttonListar��5      ���#C9501A$��Listar��6<   $
��Left=�6M   $��355,196,0,0q�6h   $	��Top=�6}   $	��150��6�   $ -0.003,0&�6�   $��35��6�   ���#000000���#0000006�   �� 5   
   -   5        $ buttonCancelar��5      ���#ff2301$��Cancelar��6>   $
��Left=�6Q   $��530,196,0,0q�6l   $	��Top=�6�   $	��150��6�   $ -0.003,0&�6�   $��35��6�   ���#000000���#000000{�.  6  &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	dataGrid1��5         
IsReadOnly . ���#fff5ee$
��Left=�6   $	��211��6�   $��
11,264,0,0q�6�   $	��Top=�6�   $	��669��6�   "	   VerticalScrollBarVisibility$
	 Auto=�6�   $
   HorizontalScrollBarVisibility$

 Auto=�6  ��69   �� *estadocontratoCollection+6  �� 5   
   -   5        $  	labelTel2��5      $��Teléfono 2:��6#   $
��Left=�69   $��408,117,0,0q�6T   $	��Top=�6i   ���#8F2A16$
��Bold"�6�   $��Tahoma)�6�   �� 5    
   -   5        $ TextTel2��5       $��5��6$   $ teléfono 2��61   $��30��6]   $��515,111,31.6,359q�6i   ��6�   �� *SelectedItem.Telefono2+$ 	dataGrid1��$ OneWay=�5!      5"      