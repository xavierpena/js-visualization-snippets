# localhostD3TreeView

This code is a modification of this other original code: http://bl.ocks.org/robschmuecker/7880033

The main modification consists in creating a javascript code that allows the execution in any local machine. 

Executing the original javascript in a local machine fails because the function `treeJSON = d3.json("flare.json", function(error, treeData) {` only lets you load `flare.json` in a "proper" server (for security reasons).

My code bypasses this restriction by directly creating a variable with the json value (in a different .js), and using it in this code without having to parse a `.json` file.

It also removes the drag and drop features of the code, which made manipulation more difficult for just visualization purposes.
