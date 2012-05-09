function __ScrollableListBoxRefineHeightAndWidth(list_id)
{
    var list = document.getElementById(list_id);
    var div = document.getElementById(list_id + '_div');
    if (div.style.height) 
    {
        // div has height we will expand the list to fit the div's height.
        // In addition we will make sure the vertical scroll bar of the list will not
        // displayed
        list.size = list.options.length;
        while (list.clientHeight < div.clientHeight)
            list.size = list.size + 1;
    }
    if (div.style.width)
    {   
        if (div.clientWidth > list.clientWidth)
        {
            // div is wider than list. We will wide the list to fill the div area
            list.style.width = div.clientWidth;
        }
        if (!div.style.height)
        {
            // div have no height this is mean the height is defined by list rows.
            // We will set the div height to be like the list height.
            div.style.height = list.offsetHeight + (list.offsetHeight - div.clientHeight);
             
            // now after we set the div height,
            // we need to remove the vertical scroll bar of the list 
            // (it will exisit when the size of the list is less than the number 
            // the amount of list's items).
            // We are doing it by set the list rows 
            if (list.size < list.options.length)
            {
                list.size = list.options.length;
            }
            else
            {
                // here we will not need the vertical scroll bar. therefor we will hide it.
                div.style.overflowY = 'hidden';
            }
        }
    }
    else 
    {
        // div has no width. this is mean the width will be set 
        // by the longest list's item. therefor we will set the div width like the list offset.
        div.style.width = list.offsetWidth;
        // here we will not need the horizontal scroll bar. therefor we will hide it.
        div.style.overflowX = 'hidden';
     }
}