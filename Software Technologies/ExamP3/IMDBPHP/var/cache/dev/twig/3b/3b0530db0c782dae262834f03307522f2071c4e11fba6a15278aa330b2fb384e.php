<?php

/* @WebProfiler/Collector/exception.html.twig */
class __TwigTemplate_f32ad73c9bc804e7d7685ce925e27ce9c7daa98efc0b9a8c89227d7076a75563 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/exception.html.twig", 1);
        $this->blocks = array(
            'head' => array($this, 'block_head'),
            'menu' => array($this, 'block_menu'),
            'panel' => array($this, 'block_panel'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_f68a00855b53c7fde33dd22686c00adc26aa16fd682992826b32abcf7624635f = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_f68a00855b53c7fde33dd22686c00adc26aa16fd682992826b32abcf7624635f->enter($__internal_f68a00855b53c7fde33dd22686c00adc26aa16fd682992826b32abcf7624635f_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $__internal_70438c4c990b3478f846ec82356560036d732676d786304ce7aa3b653dc73178 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_70438c4c990b3478f846ec82356560036d732676d786304ce7aa3b653dc73178->enter($__internal_70438c4c990b3478f846ec82356560036d732676d786304ce7aa3b653dc73178_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_f68a00855b53c7fde33dd22686c00adc26aa16fd682992826b32abcf7624635f->leave($__internal_f68a00855b53c7fde33dd22686c00adc26aa16fd682992826b32abcf7624635f_prof);

        
        $__internal_70438c4c990b3478f846ec82356560036d732676d786304ce7aa3b653dc73178->leave($__internal_70438c4c990b3478f846ec82356560036d732676d786304ce7aa3b653dc73178_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_20f4c1bf0f4fa1aa89d081fea4e7a7f8c353ad8afa41418cf5561ca52a0f06cc = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_20f4c1bf0f4fa1aa89d081fea4e7a7f8c353ad8afa41418cf5561ca52a0f06cc->enter($__internal_20f4c1bf0f4fa1aa89d081fea4e7a7f8c353ad8afa41418cf5561ca52a0f06cc_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        $__internal_dbc57a87335706462a4e6adb7aeceb517e6f70fc0c4cd6d7731b2efa7007c124 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_dbc57a87335706462a4e6adb7aeceb517e6f70fc0c4cd6d7731b2efa7007c124->enter($__internal_dbc57a87335706462a4e6adb7aeceb517e6f70fc0c4cd6d7731b2efa7007c124_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    ";
        if ($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
            // line 5
            echo "        <style>
            ";
            // line 6
            echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception_css", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
            echo "
        </style>
    ";
        }
        // line 9
        echo "    ";
        $this->displayParentBlock("head", $context, $blocks);
        echo "
";
        
        $__internal_dbc57a87335706462a4e6adb7aeceb517e6f70fc0c4cd6d7731b2efa7007c124->leave($__internal_dbc57a87335706462a4e6adb7aeceb517e6f70fc0c4cd6d7731b2efa7007c124_prof);

        
        $__internal_20f4c1bf0f4fa1aa89d081fea4e7a7f8c353ad8afa41418cf5561ca52a0f06cc->leave($__internal_20f4c1bf0f4fa1aa89d081fea4e7a7f8c353ad8afa41418cf5561ca52a0f06cc_prof);

    }

    // line 12
    public function block_menu($context, array $blocks = array())
    {
        $__internal_db0c7d543f6c97ea01c7ed9b731e0c3e0b58170e6282efad61220f5a3bbdd0d8 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_db0c7d543f6c97ea01c7ed9b731e0c3e0b58170e6282efad61220f5a3bbdd0d8->enter($__internal_db0c7d543f6c97ea01c7ed9b731e0c3e0b58170e6282efad61220f5a3bbdd0d8_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        $__internal_c85a54aaa6a7cb735049f4fd38fcd939fd6ea3d5d6b1591a8c3f3481cf73c9cc = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_c85a54aaa6a7cb735049f4fd38fcd939fd6ea3d5d6b1591a8c3f3481cf73c9cc->enter($__internal_c85a54aaa6a7cb735049f4fd38fcd939fd6ea3d5d6b1591a8c3f3481cf73c9cc_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 13
        echo "    <span class=\"label ";
        echo (($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) ? ("label-status-error") : ("disabled"));
        echo "\">
        <span class=\"icon\">";
        // line 14
        echo twig_include($this->env, $context, "@WebProfiler/Icon/exception.svg");
        echo "</span>
        <strong>Exception</strong>
        ";
        // line 16
        if ($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
            // line 17
            echo "            <span class=\"count\">
                <span>1</span>
            </span>
        ";
        }
        // line 21
        echo "    </span>
";
        
        $__internal_c85a54aaa6a7cb735049f4fd38fcd939fd6ea3d5d6b1591a8c3f3481cf73c9cc->leave($__internal_c85a54aaa6a7cb735049f4fd38fcd939fd6ea3d5d6b1591a8c3f3481cf73c9cc_prof);

        
        $__internal_db0c7d543f6c97ea01c7ed9b731e0c3e0b58170e6282efad61220f5a3bbdd0d8->leave($__internal_db0c7d543f6c97ea01c7ed9b731e0c3e0b58170e6282efad61220f5a3bbdd0d8_prof);

    }

    // line 24
    public function block_panel($context, array $blocks = array())
    {
        $__internal_2d188efdbdd1c8f66e6816fb4eff151307b2978678ab95d826fab6f6515d549e = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_2d188efdbdd1c8f66e6816fb4eff151307b2978678ab95d826fab6f6515d549e->enter($__internal_2d188efdbdd1c8f66e6816fb4eff151307b2978678ab95d826fab6f6515d549e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        $__internal_4a6de833a238cb8ebf5a013e6003d7ec22a477351d849335b5457b748839d497 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_4a6de833a238cb8ebf5a013e6003d7ec22a477351d849335b5457b748839d497->enter($__internal_4a6de833a238cb8ebf5a013e6003d7ec22a477351d849335b5457b748839d497_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 25
        echo "    <h2>Exceptions</h2>

    ";
        // line 27
        if ( !$this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
            // line 28
            echo "        <div class=\"empty\">
            <p>No exception was thrown and caught during the request.</p>
        </div>
    ";
        } else {
            // line 32
            echo "        <div class=\"sf-reset\">
            ";
            // line 33
            echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
            echo "
        </div>
    ";
        }
        
        $__internal_4a6de833a238cb8ebf5a013e6003d7ec22a477351d849335b5457b748839d497->leave($__internal_4a6de833a238cb8ebf5a013e6003d7ec22a477351d849335b5457b748839d497_prof);

        
        $__internal_2d188efdbdd1c8f66e6816fb4eff151307b2978678ab95d826fab6f6515d549e->leave($__internal_2d188efdbdd1c8f66e6816fb4eff151307b2978678ab95d826fab6f6515d549e_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/exception.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  138 => 33,  135 => 32,  129 => 28,  127 => 27,  123 => 25,  114 => 24,  103 => 21,  97 => 17,  95 => 16,  90 => 14,  85 => 13,  76 => 12,  63 => 9,  57 => 6,  54 => 5,  51 => 4,  42 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block head %}
    {% if collector.hasexception %}
        <style>
            {{ render(path('_profiler_exception_css', { token: token })) }}
        </style>
    {% endif %}
    {{ parent() }}
{% endblock %}

{% block menu %}
    <span class=\"label {{ collector.hasexception ? 'label-status-error' : 'disabled' }}\">
        <span class=\"icon\">{{ include('@WebProfiler/Icon/exception.svg') }}</span>
        <strong>Exception</strong>
        {% if collector.hasexception %}
            <span class=\"count\">
                <span>1</span>
            </span>
        {% endif %}
    </span>
{% endblock %}

{% block panel %}
    <h2>Exceptions</h2>

    {% if not collector.hasexception %}
        <div class=\"empty\">
            <p>No exception was thrown and caught during the request.</p>
        </div>
    {% else %}
        <div class=\"sf-reset\">
            {{ render(path('_profiler_exception', { token: token })) }}
        </div>
    {% endif %}
{% endblock %}
", "@WebProfiler/Collector/exception.html.twig", "C:\\Users\\ASUS\\ExamP3\\IMDBPHP\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\WebProfilerBundle\\Resources\\views\\Collector\\exception.html.twig");
    }
}
