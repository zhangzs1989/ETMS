<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Juneitrain.aspx.cs" Inherits="zzs.sddj.Webapp.DepartmentUI.Juneitrain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>局内培训提交</title>
    <%--<link href="css/demo.css" rel="stylesheet" />--%>
    <style type="text/css">
        .auto-style1 {
            left: -71px;
            top: 5px;
            width: 300px;
            height:30px;
            border:1px solid green;
        }
        .auto-style2 {
            height: 49px;
        }
        .auto-style3 {
            width: 268435456px;
        }
        .auto-style4 {
            width: 680px;
        }
        table,tr
        {
            border:1px none green;
            align-content:center;
            vertical-align:middle;
            text-align:center;
            
            
        }
        table
        {
            border-collapse:collapse;
            align-content:center;
           
        }

        .auto-style6 {
            width: 381px;
            border:1px solid green;
        }
        .listboxcss{
            border:1px solid green;
            border-right-color:aqua;
            color:red;
            width:250px;
            border-left:-50px;

        }

        .auto-style7 {
            width: 462px;
            border:1px solid green;
        }

        .auto-style8 {
            height: 57px;
        }

        /*.auto-style9 {
            border-right: 1px solid aqua;
            color: red;
            width: 250px;
            left: 7px;
            top: -2px;
            height: 265px;
            border-left-style: none;
            border-left-color: inherit;
            border-left-width: -50px;
            border-top-style: solid;
            border-top-color: inherit;
            border-top-width: 1px;
            border-bottom-style: solid;
            border-bottom-color: inherit;
            border-bottom-width: 1px;
        }*/

        .auto-style9 {
            border-right: 1px solid aqua;
            border-top: 1px solid green;
            border-bottom: 1px solid green;
            color: red;
            left: 7px;
            top: -24px;
            border-left-style: none;
            border-left-color: inherit;
            border-left-width: -50px;
        }
        .auto-style10 {
            border-right: 1px solid aqua;
            border-top: 1px solid green;
            border-bottom: 1px solid green;
            color: red;
            left: 7px;
            top: 5px;
            border-left-style: none;
            border-left-color: inherit;
            border-left-width: -50px;
        }

    </style>
    <script type="text/javascript"> 
 //左移右 
   
  /*<input name="add" id="add" type="button" value="--->"/>*/ 
  document.getElementById("add").onclick = function add() 
  { 
      var firstSel = document.getElementById("leftlistbox");
   var option = firstSel.getElementsByTagName("option"); 
   //javascript的数组是动态数组，长度是可以变的。 
   //所以先取得下拉列表的长度，避免option被移走后长度变小，导致后面循环终止，出现beg 
   var oplength=option.length; 
   var secondSel = document.getElementById("rightlistbox");
   for(i=0;i<oplength;i++) 
   { 
     /* 
      selectedIndex: 该下标返回下拉列表的索引值 
      注： 如果有多个被选中的情况下，永远返回第一个选中的索引值，索引最小的那个 
         如果没有被选中的情况下，返回-1 
         selectedIndex是<select>的属性 
     */ 
     if(firstSel.selectedIndex!=-1) 
     { 
       secondSel.appendChild(option[firstSel.selectedIndex]); 
     } 
   } 
     
  } 
    
  /*<input name="add_all" id="add_all" type="button" value="===>"/>*/ 
  document.getElementById("add_all").onclick = function addAll() 
  { 
      var firstSel = document.getElementById("leftlistbox");
   var option = firstSel.getElementsByTagName("option"); 
   //javascript的数组是动态数组，长度是可以变的。 
   //所以先取得下拉列表的长度，避免option被移走后长度变小，导致后面循环终止，出现beg 
   var oplength=option.length; 
   var secondSel = document.getElementById("rightlistbox");
   for(i=0;i<oplength;i++) 
   { 
    /*因为javascript的数组是动态数组，长度是可以变的。所以当移走全部把数 
    组的值移走（一个一个的移走，数组长度马上-1，所以数组下标也是-1.因次我们要把每次移的是走下标为0的那个 
    数，这样才保证可以全部移走）*/ 
    secondSel.appendChild(option[0]); 
   } 
  } 
    
  /*双击后把option移到右边*/ 
  document.getElementById("leftlistbox").ondblclick = function dblclick()
  { 
    /*方法一*/ 
    /* 
   var firstSel = document.getElementById("first"); 
   var option = firstSel.getElementsByTagName("option"); 
   //javascript的数组是动态数组，长度是可以变的。 
   //所以先取得下拉列表的长度，避免option被移走后长度变小，导致后面循环终止，出现beg 
   var oplength=option.length; 
   var secondSel = document.getElementById("second"); 
   for(i=0;i<oplength;i++) 
   { 
      //双击可以看成：第一次点击选中，第二次点击移动 
      secondSel.appendChild(option[firstSel.selectedIndex]);   
   } 
   */ 
     
   /*方法二*/ 
   /* 
   this: this表示document.getElementById("first")  下拉列表 
      this.selectedIndex表示下拉列表选中的项 
   */ 
      var secondSel = document.getElementById("rightlistbox");
    secondSel.appendChild(this[this.selectedIndex]); 
  } 
    
    
    
    
  //右移左 
    
    
  /*<input name="remove" id="remove" type="button" value="<---"/>*/ 
  document.getElementById("remove").onclick = function remove() 
  { 
      var secondSel = document.getElementById("rightlistbox");
   var firstSel = document.getElementById("leftlistbox"); 
   var option = secondSel.getElementsByTagName("option"); 
   //javascript的数组是动态数组，长度是可以变的。 
   //所以先取得下拉列表的长度，避免option被移走后长度变小，导致后面循环终止，出现beg 
   var oplength=option.length; 
   for(i=0;i<oplength;i++) 
   { 
     /* 
      selectedIndex: 该下标返回下拉列表的索引值 
      注： 如果有多个被选中的情况下，永远返回第一个选中的索引值，索引最小的那个 
         如果没有被选中的情况下，返回-1 
         selectedIndex是<select>的属性 
     */ 
     if(secondSel.selectedIndex!=-1) 
     { 
       firstSel.appendChild(option[secondSel.selectedIndex]); 
     } 
   } 
     
  } 
    
  /*<input name="remove_all" id="remove_all" type="button" value="<==="/>*/ 
  document.getElementById("remove_all").onclick = function remove_all() 
  { 
      var secondSel = document.getElementById("rightlistbox");
   var firstSel = document.getElementById("leftlistbox"); 
   var option = secondSel.getElementsByTagName("option"); 
   //javascript的数组是动态数组，长度是可以变的。 
   //所以先取得下拉列表的长度，避免option被移走后长度变小，导致后面循环终止，出现beg 
   var oplength=option.length; 
   for(i=0;i<oplength;i++) 
   { 
    /*因为javascript的数组是动态数组，长度是可以变的。所以当移走全部把数 
    组的值移走（一个一个的移走，数组长度马上-1，所以数组下标也是-1.因次我们要把每次移的是走下标为0的那个 
    数，这样才保证可以全部移走）*/ 
    firstSel.appendChild(option[0]); 
   } 
  } 
    
  /*双击后把option移到右边*/ 
  document.getElementById("rightlistbox").ondblclick = function dblclick()
  { 
    /*方法一*/ 
    /* 
   var secondSel = document.getElementById("second"); 
   var firstSel = document.getElementById("first"); 
   var option = secondSel.getElementsByTagName("option"); 
   //javascript的数组是动态数组，长度是可以变的。 
   //所以先取得下拉列表的长度，避免option被移走后长度变小，导致后面循环终止，出现beg 
   var oplength=option.length; 
   for(i=0;i<oplength;i++) 
   { 
      //双击可以看成：第一次点击选中，第二次点击移动 
      firstSel.appendChild(option[secondSel.selectedIndex]);   
   } 
   */ 
     
   /*方法二*/ 
   /* 
   this: this表示document.getElementById("second")  下拉列表 
      this.selectedIndex表示下拉列表选中的项 
   */ 
    var firstSel = document.getElementById("leftlistbox"); 
    firstSel.appendChild(this[this.selectedIndex]); 
  } 
</script> 

</head>
<body style="height: 571px">
    <form runat="server" action="Juneitrain.aspx" method="post">
        <table class="auto-style4">
            <tr><td>培 训 班 名 称:</td><td colspan="2"><input type="text" id="peixunname" name="peixunname"  runat="server"  class="auto-style6"/></td></tr>
            <tr><td>培 训 地 点   :</td><td colspan="2"><input type="text" id="peixundidian" name="peixundidian" runat="server" class="auto-style6"/></td></tr>
            <tr><td>培 训 时 间   :</td><td colspan="2"><input type="text" id="peixuntime" name="peixuntime"  runat="server" class="auto-style6"/></td></tr>
            <tr><td>培 训 学 时   :</td><td colspan="2"><input type="text" id="peixunfangshi" name="peixunxueshi"  runat="server" class="auto-style6"/></td></tr>
            <tr><td>培 训 简 介   :  </td><td colspan="2"><textarea id="peixunjianjie" name="peixunjianjie" rows="6" runat="server" placeholder="此项内容必填，某些浏览器可能不显示*号" class="auto-style7"></textarea></td></tr>
            <tr><td class="auto-style8">参加培训人员单位:      </td><td colspan="2" class="auto-style8"><asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style1" AutoPostBack="true"></asp:DropDownList>
                </td></tr>
            <hr />
            <tr><td colspan="3" class="auto-style2"></td></tr>
            <tr><td rowspan="4"><asp:ListBox ID="leftlistbox" runat="server" CssClass="auto-style10" SelectionMode="Multiple" Height="214px" Width="129px" OnSelectedIndexChanged="Button1_Click" AutoPostBack="True"></asp:ListBox></td></tr>
            <tr><td> </td><td rowspan="3"><asp:ListBox ID="rightlistbox" runat="server"  CssClass="auto-style9" SelectionMode="Multiple" Height="213px" Width="126px" AutoPostBack="True" ></asp:ListBox></td></tr>
            
            <tr><td class="auto-style3">
                <asp:Button ID="add" runat="server" Height="35px" Text="添加 =>" Width="124px" OnClick="Button1_Click" />
                </td></tr>
            
            <tr><td class="auto-style3">
                <asp:Button ID="remove" runat="server" Height="36px" Text="删除 <=" Width="118px" OnClick="Button2_Click" />
                </td></tr>
            <tr><td colspan="3" class="auto-style2"></td></tr>
            <hr />
            <tr><td class="auto-style3" colspan="3">
                <asp:Button ID="Button3" runat="server" Height="35px" Text="提 交" Width="124px" OnClick="Button1_Click" />
                </td></tr>
        </table>
        
    </form>
</body>
</html>