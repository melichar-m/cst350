@Code
    ViewData("Title") = "Contact"
End Code

<h2>@ViewData("Title").</h2>
<h3>@ViewData("Message")</h3>
<span style="background-color: #FFFF00">This is not a viewbag, but I think it really highlights the point of the activity.</span>
<address>
    One Microsoft Way<br />
    Redmond, WA 98052-6399<br />
    <abbr title="Phone">P:</abbr>
    425.555.0100
</address>

<address>
    <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
    <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
</address>
