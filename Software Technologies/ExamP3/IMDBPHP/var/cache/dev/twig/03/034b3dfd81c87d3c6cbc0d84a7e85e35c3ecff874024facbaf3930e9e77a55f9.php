<?php

/* @WebProfiler/Profiler/open.html.twig */
class __TwigTemplate_ac12c574132227140b686f2370e565f8f8810500cd69524bf391681d60e32a52 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/base.html.twig", "@WebProfiler/Profiler/open.html.twig", 1);
        $this->blocks = array(
            'head' => array($this, 'block_head'),
            'body' => array($this, 'block_body'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/base.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_b5f0b3dc3488f3826959e5ef6c180873eb6b57350fa89aa48f8d03090c19c5c6 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_b5f0b3dc3488f3826959e5ef6c180873eb6b57350fa89aa48f8d03090c19c5c6->enter($__internal_b5f0b3dc3488f3826959e5ef6c180873eb6b57350fa89aa48f8d03090c19c5c6_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Profiler/open.html.twig"));

        $__internal_8f0ee96faa4d6668fca56107b053d8d54163bcd4a0b89d473ba4006947bc5044 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_8f0ee96faa4d6668fca56107b053d8d54163bcd4a0b89d473ba4006947bc5044->enter($__internal_8f0ee96faa4d6668fca56107b053d8d54163bcd4a0b89d473ba4006947bc5044_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Profiler/open.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_b5f0b3dc3488f3826959e5ef6c180873eb6b57350fa89aa48f8d03090c19c5c6->leave($__internal_b5f0b3dc3488f3826959e5ef6c180873eb6b57350fa89aa48f8d03090c19c5c6_prof);

        
        $__internal_8f0ee96faa4d6668fca56107b053d8d54163bcd4a0b89d473ba4006947bc5044->leave($__internal_8f0ee96faa4d6668fca56107b053d8d54163bcd4a0b89d473ba4006947bc5044_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_80452766aa80fa3804a75a392533fc8d1f43d38455098c9deda8161f1d5175dc = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_80452766aa80fa3804a75a392533fc8d1f43d38455098c9deda8161f1d5175dc->enter($__internal_80452766aa80fa3804a75a392533fc8d1f43d38455098c9deda8161f1d5175dc_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        $__internal_745eb2a2e2537a6b829576710f470acf93772d6767d5b89c65fabdc8917dce88 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_745eb2a2e2537a6b829576710f470acf93772d6767d5b89c65fabdc8917dce88->enter($__internal_745eb2a2e2537a6b829576710f470acf93772d6767d5b89c65fabdc8917dce88_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    <style>
        ";
        // line 5
        echo twig_include($this->env, $context, "@WebProfiler/Profiler/open.css.twig");
        echo "
    </style>
";
        
        $__internal_745eb2a2e2537a6b829576710f470acf93772d6767d5b89c65fabdc8917dce88->leave($__internal_745eb2a2e2537a6b829576710f470acf93772d6767d5b89c65fabdc8917dce88_prof);

        
        $__internal_80452766aa80fa3804a75a392533fc8d1f43d38455098c9deda8161f1d5175dc->leave($__internal_80452766aa80fa3804a75a392533fc8d1f43d38455098c9deda8161f1d5175dc_prof);

    }

    // line 9
    public function block_body($context, array $blocks = array())
    {
        $__internal_7fa3df639e06e6726088e6b79cb81a188d92b9ad20dfa2887562ea114b60b988 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_7fa3df639e06e6726088e6b79cb81a188d92b9ad20dfa2887562ea114b60b988->enter($__internal_7fa3df639e06e6726088e6b79cb81a188d92b9ad20dfa2887562ea114b60b988_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        $__internal_38e35ce8dd8db632d1071cb1db7e1ca5307b583e56d11cdeaab44b4a96324461 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_38e35ce8dd8db632d1071cb1db7e1ca5307b583e56d11cdeaab44b4a96324461->enter($__internal_38e35ce8dd8db632d1071cb1db7e1ca5307b583e56d11cdeaab44b4a96324461_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 10
        echo "<div class=\"header\">
    <h1>";
        // line 11
        echo twig_escape_filter($this->env, ($context["file"] ?? $this->getContext($context, "file")), "html", null, true);
        echo " <small>line ";
        echo twig_escape_filter($this->env, ($context["line"] ?? $this->getContext($context, "line")), "html", null, true);
        echo "</small></h1>
    <a class=\"doc\" href=\"https://symfony.com/doc/";
        // line 12
        echo twig_escape_filter($this->env, twig_constant("Symfony\\Component\\HttpKernel\\Kernel::VERSION"), "html", null, true);
        echo "/reference/configuration/framework.html#ide\" rel=\"help\">Open in your IDE?</a>
</div>
<div class=\"source\">
    ";
        // line 15
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\CodeExtension')->fileExcerpt(($context["filename"] ?? $this->getContext($context, "filename")), ($context["line"] ?? $this->getContext($context, "line")),  -1);
        echo "
</div>
";
        
        $__internal_38e35ce8dd8db632d1071cb1db7e1ca5307b583e56d11cdeaab44b4a96324461->leave($__internal_38e35ce8dd8db632d1071cb1db7e1ca5307b583e56d11cdeaab44b4a96324461_prof);

        
        $__internal_7fa3df639e06e6726088e6b79cb81a188d92b9ad20dfa2887562ea114b60b988->leave($__internal_7fa3df639e06e6726088e6b79cb81a188d92b9ad20dfa2887562ea114b60b988_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Profiler/open.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  90 => 15,  84 => 12,  78 => 11,  75 => 10,  66 => 9,  53 => 5,  50 => 4,  41 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends '@WebProfiler/Profiler/base.html.twig' %}

{% block head %}
    <style>
        {{ include('@WebProfiler/Profiler/open.css.twig') }}
    </style>
{% endblock %}

{% block body %}
<div class=\"header\">
    <h1>{{ file }} <small>line {{ line }}</small></h1>
    <a class=\"doc\" href=\"https://symfony.com/doc/{{ constant('Symfony\\\\Component\\\\HttpKernel\\\\Kernel::VERSION') }}/reference/configuration/framework.html#ide\" rel=\"help\">Open in your IDE?</a>
</div>
<div class=\"source\">
    {{ filename|file_excerpt(line, -1) }}
</div>
{% endblock %}
", "@WebProfiler/Profiler/open.html.twig", "C:\\Users\\ASUS\\ExamP3\\IMDBPHP\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\WebProfilerBundle\\Resources\\views\\Profiler\\open.html.twig");
    }
}
