   M S B A M L   `   `   `  ����D  @ProjetBDD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ProjetBDD	ProjetBDD  5          ProjetBDD.Stock   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      )localclr-namespace:ProjetBDD     5        � Title$  Stock��5      $	��450��6   $	��800��6(   .��5	   
   � .+�5      �� -   5         ��Name$ stock_piece��5      $��Stock Pièces��6*   $
��Left=�6A   $��	30,30,0,0q�6\   $	��Top=�6o   $	��105��6�   $��40��6�    J� RenderTransformOrigin$ 0.491,0.823&�6�   6�   �� 5      -   5        $ stock_fournisseur��5      $��Stock Fournisseur��60   $
��Left=�6L   $��	30,90,0,0q�6g   $	��Top=�6z   $	��105��6�   $��40��6�   6�   �� 5      -   5        $ 
stock_velo��5      $��Stock Vélo��6)   $
��Left=�6>   $��
30,150,0,0q�6Y   $	��Top=�6m   $	��105��6�   $��40��6�   6�   �� 5      -   5        $
 Menu��5      $
��Menu��6#   $
��Left=�62   $��
30,346,0,0q�6M   $	��Top=�6a   $	��105��6y   $ -0.104,-1.12&�6�   $��40��6�   6�   �� 5      -   5        $ stock_modele��5      $��Stock par modèle��6+   $
��Left=�6F   $��
200,30,0,0q�6a   $	��Top=�6u   $	��105��6�   $��40��6�   6�   �� 5      -   5         ��Name$ search1_txt��5      $
��Left=�6+   $��23��6F   $��
200,76,0,0q�6R    �� TextWrapping$
 Wrap=�6f   $	��Top=�6z   $	��105��6�   �� 5      -   5        $ stock_marque��5      $��Stock par marque��6+   $
��Left=�6F   $��200,105,0,0q�6a   $	��Top=�6v   $	��105��6�   $��40��6�   6�   �� 5      -   5        $ search2_txt��5      $
��Left=�6+   $��23��6F   $��200,150,0,0q�6R   $
 Wrap=�6g   $	��Top=�6{   $	��105��6�   &   System.Windows.Controls.DataGrid  5      -	   5          Name$ datagrid��5      $
��Left=�6)   $	��286��6D   $��
354,30,0,0q�6Q   $	��Top=�6e   $	��430��6}   �� 5      -
   5        $ gestion_stock_v��5      $��Gestion Stock Velo��6.   $
��Left=�6K   $��
30,210,0,0q�6f   $	��Top=�6z   $	��105��6�   $��40��6�   6�   �� 5   
   -   5        $ gestion_stock_p��5      $��Gestion Stock Pièce��6*   $
��Left=�6H   $��
30,270,0,0q�6c   $	��Top=�6w   $	��105��6�   $��40��6�   6�   �� 5   
   -   5        $ 	Menu_Copy��5      $
��Menu��6$   $
��Left=�63   $��
30,346,0,0q�6N   $	��Top=�6b   $	��105��6z   $ -0.104,-1.12&�6�   $��40��6�   6�   5      5      