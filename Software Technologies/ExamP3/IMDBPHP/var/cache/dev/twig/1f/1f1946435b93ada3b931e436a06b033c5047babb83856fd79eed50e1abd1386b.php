<?php

/* film/index.html.twig */
class __TwigTemplate_6ea26922b3f615ba99ae213a268e556f5b86e2a98a7a57f7d3c04f0c4d3cc4d8 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", "film/index.html.twig", 1);
        $this->blocks = array(
            'main' => array($this, 'block_main'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "base.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_f778cee799aac8482a21cf4a3531b03c763ef6bd0a4917ca17f6eef901a2872d = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_f778cee799aac8482a21cf4a3531b03c763ef6bd0a4917ca17f6eef901a2872d->enter($__internal_f778cee799aac8482a21cf4a3531b03c763ef6bd0a4917ca17f6eef901a2872d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "film/index.html.twig"));

        $__internal_6577573b4bdcdff6e90e85cd0af2423d67c0e0b0003aedf2c777505457479000 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_6577573b4bdcdff6e90e85cd0af2423d67c0e0b0003aedf2c777505457479000->enter($__internal_6577573b4bdcdff6e90e85cd0af2423d67c0e0b0003aedf2c777505457479000_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "film/index.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_f778cee799aac8482a21cf4a3531b03c763ef6bd0a4917ca17f6eef901a2872d->leave($__internal_f778cee799aac8482a21cf4a3531b03c763ef6bd0a4917ca17f6eef901a2872d_prof);

        
        $__internal_6577573b4bdcdff6e90e85cd0af2423d67c0e0b0003aedf2c777505457479000->leave($__internal_6577573b4bdcdff6e90e85cd0af2423d67c0e0b0003aedf2c777505457479000_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_8fe032bf269ecb7b165579ef2c4260d66ab5d904334d9a647053874958f3bd75 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_8fe032bf269ecb7b165579ef2c4260d66ab5d904334d9a647053874958f3bd75->enter($__internal_8fe032bf269ecb7b165579ef2c4260d66ab5d904334d9a647053874958f3bd75_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_a171ea38478cac9b47bc65eb8783641574bc93470d1000219c368c3b424f2c19 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_a171ea38478cac9b47bc65eb8783641574bc93470d1000219c368c3b424f2c19->enter($__internal_a171ea38478cac9b47bc65eb8783641574bc93470d1000219c368c3b424f2c19_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "<h1>All Films</h1>

<div>
    <button class=\"add-new\" onclick=\"location.href='/create'\">Create New Film</button>
</div>

<section>
    <div>
        <table>
            <tr>
                <th>Name</th>
                <th>Genre</th>
                <th>Director</th>
                <th>Year</th>
                <th>Actions</th>
            </tr>
            ";
        // line 20
        $context['_parent'] = $context;
        $context['_seq'] = twig_ensure_traversable(($context["films"] ?? $this->getContext($context, "films")));
        foreach ($context['_seq'] as $context["_key"] => $context["film"]) {
            // line 21
            echo "            <tr>
                <td>";
            // line 22
            echo twig_escape_filter($this->env, $this->getAttribute($context["film"], "name", array()), "html", null, true);
            echo "</td>
                <td>";
            // line 23
            echo twig_escape_filter($this->env, $this->getAttribute($context["film"], "genre", array()), "html", null, true);
            echo "</td>
                <td>";
            // line 24
            echo twig_escape_filter($this->env, $this->getAttribute($context["film"], "director", array()), "html", null, true);
            echo "</td>
                <td>";
            // line 25
            echo twig_escape_filter($this->env, $this->getAttribute($context["film"], "year", array()), "html", null, true);
            echo "</td>
                <td>
                    <button onclick=\"location.href='/edit/";
            // line 27
            echo twig_escape_filter($this->env, $this->getAttribute($context["film"], "id", array()), "html", null, true);
            echo "'\" class=\"edit\">Edit</button>
                    <button onclick=\"location.href='/delete/";
            // line 28
            echo twig_escape_filter($this->env, $this->getAttribute($context["film"], "id", array()), "html", null, true);
            echo "'\" class=\"delete\">Delete</button>
                </td>
            </tr>
            ";
        }
        $_parent = $context['_parent'];
        unset($context['_seq'], $context['_iterated'], $context['_key'], $context['film'], $context['_parent'], $context['loop']);
        $context = array_intersect_key($context, $_parent) + $_parent;
        // line 32
        echo "        </table>
    </div>
</section>
";
        
        $__internal_a171ea38478cac9b47bc65eb8783641574bc93470d1000219c368c3b424f2c19->leave($__internal_a171ea38478cac9b47bc65eb8783641574bc93470d1000219c368c3b424f2c19_prof);

        
        $__internal_8fe032bf269ecb7b165579ef2c4260d66ab5d904334d9a647053874958f3bd75->leave($__internal_8fe032bf269ecb7b165579ef2c4260d66ab5d904334d9a647053874958f3bd75_prof);

    }

    public function getTemplateName()
    {
        return "film/index.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  105 => 32,  95 => 28,  91 => 27,  86 => 25,  82 => 24,  78 => 23,  74 => 22,  71 => 21,  67 => 20,  49 => 4,  40 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends \"base.html.twig\" %}

{% block main %}
<h1>All Films</h1>

<div>
    <button class=\"add-new\" onclick=\"location.href='/create'\">Create New Film</button>
</div>

<section>
    <div>
        <table>
            <tr>
                <th>Name</th>
                <th>Genre</th>
                <th>Director</th>
                <th>Year</th>
                <th>Actions</th>
            </tr>
            {% for film in films %}
            <tr>
                <td>{{ film.name }}</td>
                <td>{{ film.genre }}</td>
                <td>{{ film.director }}</td>
                <td>{{ film.year }}</td>
                <td>
                    <button onclick=\"location.href='/edit/{{ film.id }}'\" class=\"edit\">Edit</button>
                    <button onclick=\"location.href='/delete/{{ film.id }}'\" class=\"delete\">Delete</button>
                </td>
            </tr>
            {% endfor %}
        </table>
    </div>
</section>
{% endblock %}", "film/index.html.twig", "C:\\Users\\ASUS\\ExamP3\\IMDBPHP\\app\\Resources\\views\\film\\index.html.twig");
    }
}
