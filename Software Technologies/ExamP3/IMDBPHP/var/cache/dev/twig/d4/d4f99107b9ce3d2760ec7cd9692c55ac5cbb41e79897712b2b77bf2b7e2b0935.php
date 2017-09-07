<?php

/* film/delete.html.twig */
class __TwigTemplate_65d25cda53d0b41c3feb9360ce8286904bf6e18104d433dcf7a0814b5d46bd9f extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", "film/delete.html.twig", 1);
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
        $__internal_28223a91c1d738f43b3eadff94fa54f654e8ed3b44d29d2e021f9c08ee63eea0 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_28223a91c1d738f43b3eadff94fa54f654e8ed3b44d29d2e021f9c08ee63eea0->enter($__internal_28223a91c1d738f43b3eadff94fa54f654e8ed3b44d29d2e021f9c08ee63eea0_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "film/delete.html.twig"));

        $__internal_da3357b9a2fc369c3f5518c29049fc6f10ec71d04889d200196c07739e61591a = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_da3357b9a2fc369c3f5518c29049fc6f10ec71d04889d200196c07739e61591a->enter($__internal_da3357b9a2fc369c3f5518c29049fc6f10ec71d04889d200196c07739e61591a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "film/delete.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_28223a91c1d738f43b3eadff94fa54f654e8ed3b44d29d2e021f9c08ee63eea0->leave($__internal_28223a91c1d738f43b3eadff94fa54f654e8ed3b44d29d2e021f9c08ee63eea0_prof);

        
        $__internal_da3357b9a2fc369c3f5518c29049fc6f10ec71d04889d200196c07739e61591a->leave($__internal_da3357b9a2fc369c3f5518c29049fc6f10ec71d04889d200196c07739e61591a_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_b971b2c06f3f15dbb4d54997ab75a81876fdab7161efac05d1a43eea498133b5 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_b971b2c06f3f15dbb4d54997ab75a81876fdab7161efac05d1a43eea498133b5->enter($__internal_b971b2c06f3f15dbb4d54997ab75a81876fdab7161efac05d1a43eea498133b5_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_61b0ae2bd3a98dda2c1784cf101cdaa43428c92a1a28fbb279d7a32184c9f8c0 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_61b0ae2bd3a98dda2c1784cf101cdaa43428c92a1a28fbb279d7a32184c9f8c0->enter($__internal_61b0ae2bd3a98dda2c1784cf101cdaa43428c92a1a28fbb279d7a32184c9f8c0_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "    <h1>Delete Film</h1>
    <section>
        <form method=\"POST\">
            <div>
                <label for=\"name\">Name</label>
                <input type=\"text\" id=\"name\" value=\"";
        // line 9
        echo twig_escape_filter($this->env, $this->getAttribute(($context["film"] ?? $this->getContext($context, "film")), "name", array()), "html", null, true);
        echo "\" name=\"film[name]\" disabled />
                <label for=\"genre\">Genre</label>
                <input type=\"text\" id=\"genre\" value=\"";
        // line 11
        echo twig_escape_filter($this->env, $this->getAttribute(($context["film"] ?? $this->getContext($context, "film")), "genre", array()), "html", null, true);
        echo "\" name=\"film[genre]\" disabled />
                <label for=\"director\">Director</label>
                <input type=\"text\" id=\"director\" value=\"";
        // line 13
        echo twig_escape_filter($this->env, $this->getAttribute(($context["film"] ?? $this->getContext($context, "film")), "director", array()), "html", null, true);
        echo "\" name=\"film[director]\" disabled />
                <label for=\"year\">Year</label>
                <input type=\"text\" id=\"year\" value=\"";
        // line 15
        echo twig_escape_filter($this->env, $this->getAttribute(($context["film"] ?? $this->getContext($context, "film")), "year", array()), "html", null, true);
        echo "\" name=\"film[year]\" disabled />

                ";
        // line 17
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Form\TwigRenderer')->searchAndRenderBlock($this->getAttribute(($context["form"] ?? $this->getContext($context, "form")), "_token", array()), 'row');
        echo "

                <button type=\"submit\" class=\"accept\">Delete</button>
                <button type=\"button\" onclick=\"location.href='/'\" class=\"cancel\">Cancel</button>
            </div>
        </form>
    </section>
";
        
        $__internal_61b0ae2bd3a98dda2c1784cf101cdaa43428c92a1a28fbb279d7a32184c9f8c0->leave($__internal_61b0ae2bd3a98dda2c1784cf101cdaa43428c92a1a28fbb279d7a32184c9f8c0_prof);

        
        $__internal_b971b2c06f3f15dbb4d54997ab75a81876fdab7161efac05d1a43eea498133b5->leave($__internal_b971b2c06f3f15dbb4d54997ab75a81876fdab7161efac05d1a43eea498133b5_prof);

    }

    public function getTemplateName()
    {
        return "film/delete.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  76 => 17,  71 => 15,  66 => 13,  61 => 11,  56 => 9,  49 => 4,  40 => 3,  11 => 1,);
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
    <h1>Delete Film</h1>
    <section>
        <form method=\"POST\">
            <div>
                <label for=\"name\">Name</label>
                <input type=\"text\" id=\"name\" value=\"{{ film.name }}\" name=\"film[name]\" disabled />
                <label for=\"genre\">Genre</label>
                <input type=\"text\" id=\"genre\" value=\"{{ film.genre }}\" name=\"film[genre]\" disabled />
                <label for=\"director\">Director</label>
                <input type=\"text\" id=\"director\" value=\"{{ film.director }}\" name=\"film[director]\" disabled />
                <label for=\"year\">Year</label>
                <input type=\"text\" id=\"year\" value=\"{{ film.year }}\" name=\"film[year]\" disabled />

                {{ form_row(form._token) }}

                <button type=\"submit\" class=\"accept\">Delete</button>
                <button type=\"button\" onclick=\"location.href='/'\" class=\"cancel\">Cancel</button>
            </div>
        </form>
    </section>
{% endblock %}", "film/delete.html.twig", "C:\\Users\\ASUS\\ExamP3\\IMDBPHP\\app\\Resources\\views\\film\\delete.html.twig");
    }
}
