   M S B A M L   `   `   `  ����L  HCifradoDescifrado, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CifradoDescifradoCifradoDescifrado  5   	   "    CifradoDescifrado.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:CifradoDescifrado     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��600��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��.5* �6   �� 5      $��* �6   �� 5      $	��.5* �6   �� 5      $��* �6   �� 5      $	��.5* �6   �� 5      $��* �6   �� 5      $	��.5* �6    � RowDefinitions 5   
   �� 5      $	��.5* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $	��.5* �6   .+�5   
   �� $��1��6   $��1��6!   $(��"Escribe la contraseña para cifrar��61   $
��Wrap=�6Z   $	��Top=�6n   �� 5   
   -   5        $��TxtBxPPOriginal��5   /   $��1��6   $��1��6   $��Bottom=�6p   �� 5   
   $��3��6   $��1��6!   $(��"Escribe la contraseña para cifrar��61   $
��Wrap=�6Z   $	��Top=�6n   �� 5    
   -   5        $��TxtBxPCOriginal��5    /   $��3��6   $��1��6   $��Bottom=�6p   �� 5!   
   -   5        $��	BtnCifrar��5!   X   $��Cifrar��6   $��1��6:   $��5��6G   {�.  $��Bottom=�6{   �� 5#   
   $��1��6   $��3��6!   $��Contraseña cifrada��61   $
��Wrap=�6K   $	��Top=�6_   �� 5$   
   -   5        $��TxtBxPPCifrada��5$   /   $��1��6   $��3��6    �� 
IsReadOnly . $��Bottom=�6X   �� 5%   
   $��3��6   $��3��6!   $��Contraseña descifrada��61   $
��Wrap=�6N   $	��Top=�6b   �� 5&   
   -   5        $��TxtBxCPOriginal��5&   /   $��3��6   $��3��6    . $��Bottom=�6Y   �� 5'   
   -   5        $��BtnDescifrar��5'   ]   $��	Descifrar��6   $��3��6@   $��5��6M   {�.  $��Bottom=�6�   5(      5)      