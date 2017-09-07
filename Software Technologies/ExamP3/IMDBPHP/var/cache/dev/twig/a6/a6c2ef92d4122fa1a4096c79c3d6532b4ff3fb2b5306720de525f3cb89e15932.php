<?php

/* film/create.html.twig */
class __TwigTemplate_009a3431b9c1c7980acb206521572a7ee7f2371c50f7fdf88da4a9578275933e extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", "film/create.html.twig", 1);
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
        $__internal_2fb7ee985f9a3c2841c8b4c935f574b7b7a5f3b19777fbc262bf51fcaff9a676 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_2fb7ee985f9a3c2841c8b4c935f574b7b7a5f3b19777fbc262bf51fcaff9a676->enter($__internal_2fb7ee985f9a3c2841c8b4c935f574b7b7a5f3b19777fbc262bf51fcaff9a676_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "film/create.html.twig"));

        $__internal_0eb8cfd816695b15c4cd1cd59066057ee21b1888752c3df2a9adbbe50028b05e = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_0eb8cfd816695b15c4cd1cd59066057ee21b1888752c3df2a9adbbe50028b05e->enter($__internal_0eb8cfd816695b15c4cd1cd59066057ee21b1888752c3df2a9adbbe50028b05e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "film/create.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_2fb7ee985f9a3c2841c8b4c935f574b7b7a5f3b19777fbc262bf51fcaff9a676->leave($__internal_2fb7ee985f9a3c2841c8b4c935f574b7b7a5f3b19777fbc262bf51fcaff9a676_prof);

        
        $__internal_0eb8cfd816695b15c4cd1cd59066057ee21b1888752c3df2a9adbbe50028b05e->leave($__internal_0eb8cfd816695b15c4cd1cd59066057ee21b1888752c3df2a9adbbe50028b05e_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_03c3d5ae9a7ebd512eac724eee62c99c8be10fb060d536f326902ad1fb35374d = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_03c3d5ae9a7ebd512eac724eee62c99c8be10fb060d536f326902ad1fb35374d->enter($__internal_03c3d5ae9a7ebd512eac724eee62c99c8be10fb060d536f326902ad1fb35374d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_179ce6e29173f4513a946b4f2d2227a9f9aed757aac324d1705989ae7e620faf = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_179ce6e29173f4513a946b4f2d2227a9f9aed757aac324d1705989ae7e620faf->enter($__internal_179ce6e29173f4513a946b4f2d2227a9f9aed757aac324d1705989ae7e620faf_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "<h1>Create Film</h1>
<section>
    <form method=\"POST\">
        <div>
            <label for=\"name\">Name</label>
            <input type=\"text\" id=\"name\" name=\"film[name]\" />
            <label for=\"genre\">Genre</label>
            <input type=\"text\" id=\"genre\" name=\"film[genre]\" />
            <label for=\"director\">Director</label>
            <input type=\"text\" id=\"director\" name=\"film[director]\" />
            <label for=\"year\">Year</label>
            <input type=\"text\" id=\"year\" name=\"film[year]\" />

            ";
        // line 17
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Form\TwigRenderer')->searchAndRenderBlock($this->getAttribute(($context["form"] ?? $this->getContext($context, "form")), "_token", array()), 'row');
        echo "

            <button type=\"submit\" class=\"accept\">Create</button>
            <button type=\"button\" onclick=\"location.href='/'\" class=\"cancel\">Cancel</button>
        </div>
    </form>
</section>
";
        
        $__internal_179ce6e29173f4513a946b4f2d2227a9f9aed757aac324d1705989ae7e620faf->leave($__internal_179ce6e29173f4513a946b4f2d2227a9f9aed757aac324d1705989ae7e620faf_prof);

        
        $__internal_03c3d5ae9a7ebd512eac724eee62c99c8be10fb060d536f326902ad1fb35374d->leave($__internal_03c3d5ae9a7ebd512eac724eee62c99c8be10fb060d536f326902ad1fb35374d_prof);

    }

    public function getTemplateName()
    {
        return "film/create.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  64 => 17,  49 => 4,  40 => 3,  11 => 1,);
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
<h1>Create Film</h1>
<section>
    <form method=\"POST\">
        <div>
            <label for=\"name\">Name</label>
            <input type=\"text\" id=\"name\" name=\"film[name]\" />
            <label for=\"genre\">Genre</label>
            <input type=\"text\" id=\"genre\" name=\"film[genre]\" />
            <label for=\"director\">Director</label>
            <input type=\"text\" id=\"director\" name=\"film[director]\" />
            <label for=\"year\">Year</label>
            <input type=\"text\" id=\"year\" name=\"film[year]\" />

            {{ form_row(form._token) }}

            <button type=\"submit\" class=\"accept\">Create</button>
            <button type=\"button\" onclick=\"location.href='/'\" class=\"cancel\">Cancel</button>
        </div>
    </form>
</section>
{% endblock %}", "film/create.html.twig", "C:\\Users\\ASUS\\ExamP3\\IMDBPHP\\app\\Resources\\views\\film\\create.html.twig");
    }
}
