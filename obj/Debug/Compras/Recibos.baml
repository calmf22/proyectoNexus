   M S B A M L   `   `   `  ����@  <Nexus, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Nexus.ComprasNexus.Compras  5   	       Nexus.Compras.Recibos   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Nexus.Compras     5   	     � Title$  Recibos��5   	   $	��500��6   $	��900��6&    � 
ResizeMode$ NoResize=�62    � WindowStartupLocation$ CenterScreen=�6H   .��5	      � .+�5
   
   �� -   5         ��Name$ label��5
      $��Numero de orden��6   $
��Left=�69   $��	93,62,0,0q�6T   $	��Top=�6g   �� 5   
   -   5         ��Name$ textBox��5      $
��Left=�6#   $��23��6>   $��
229,66,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��120��6�   �� 5   
   -   5        $ label1��5      $��	Proveedor��6    $
��Left=�64   $��
93,113,0,0q�6O   $	��Top=�6c   �� 5   
   -   5        $ textBox1��5      $
��Left=�6$   $��23��6?   $��192,116,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 5   
   ���	#FFF4F4F5$
��Left=�6%   $	��210��6@   $��
55,198,0,0q�6M   
���   �$	��Top=�6p   $	��300��6�   �� 5   
   ���	#FFF4F4F5$
��Left=�6%   $	��210��6@   $��532,198,0,0q�6M   
���   �$	��Top=�6q   $	��300��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5      $
��Left=�6%   $��
55,228,0,0q�6@   $	��Top=�6T   $	��180��6l   $	��300��6y     5   
   -   5        $ 	dataGrid1��5      $
��Left=�6&   $��532,228,0,0q�6A   $	��Top=�6V   $	��180��6n   $	��300��6{   �� 5   
   -   5        $ label2��5      $��Ordenado��6    $
��Left=�63   $��150,202,0,0q�6N   $	��Top=�6c   �� 5   
   -   5        $ label3��5      $��Recibido��6    $
��Left=�63   $��650,202,0,0q�6N   $	��Top=�6c   �� 5   
   -	   5         ��Name$ button��5      $��Cancelar balance abierto��6!   $
��Left=�6D   $��
701,60,0,0q�6_   $	��Top=�6s   $	��150��6�   $��30��6�   �� 5   
   -
   5        $ button1��5      $��Descargar a inventario��6"   $
��Left=�6C   $��613,138,0,0q�6^   $	��Top=�6s   $	��150��6�   $��30��6�   5      5      